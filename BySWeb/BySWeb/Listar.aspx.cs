using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;
using BySLib.BL;
using BySWeb.Utilities;
using System.Configuration;

namespace BySWeb
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["t"] != null)
                PopulateNewsItems(null);

        }

        protected List<ProductoEN> obtenerLista()
        {
            List<ProductoEN> l = null;
            string n = "";

            switch (Request.QueryString["t"])
            {
                //ultimos articulos
                case "u":
                    l = ProductoBL.GetByUltimosEN(Tools.GetDbCnxStr());
                    lbBusqueda.Text = "Últimos productos";
                    break;

                //por categoría
                case "c":
                    n = Request.QueryString["n"];
                    l = ProductoBL.GetByCategoriaEN(Tools.GetDbCnxStr(), Convert.ToInt32(n));

                    lbBusqueda.Text = "Categoría " + CategoriaBL.GetById(Tools.GetDbCnxStr(), Convert.ToInt32(n)).Nombre;
                    break;
                //por subcategoria
                case "s":
                    n = Request.QueryString["n"];
                    l = ProductoBL.GetBySubcategoriaEN(Tools.GetDbCnxStr(), Convert.ToInt32(n));
                    lbBusqueda.Text = "Categoría " + SubcategoriaBL.GetById(Tools.GetDbCnxStr(), Convert.ToInt32(n)).Nombre;
                    break;

                //busqueda
                case "b":
                    n = Request.QueryString["n"];
                    l = ProductoBL.GetByBusquedaEN(Tools.GetDbCnxStr(), n);
                    lbBusqueda.Text = n;
                    break;

                //productos
                case "m":
                    n = Request.QueryString["n"];
                    l = ProductoBL.GetByIdPropietarioEN(Tools.GetDbCnxStr(), Convert.ToInt32(n));
                    lbBusqueda.Text = "Productos de " + UsuarioBL.GetByIdToEN(Tools.GetDbCnxStr(), Convert.ToInt32(n)).Nombre;
                    break;

                //mis pujas
                case "p":
                    if (Session["LoggedIn"] == "true")
                    {

                        l = ProductoBL.GetByPujadosIdPropietarioEN(Tools.GetDbCnxStr(), Convert.ToInt32(Session["userId"]));
                    }
                    else
                    {
                        lbError.Text = "Necesitas estar loggeado para ver esto";

                    }
                    lbBusqueda.Text = "Mis productos";
                    break;

                //mis compras
                case "mc":
                    if (Session["LoggedIn"] == "true")
                    {

                        l = ProductoBL.GetByCompradosIdPropietarioEN(Tools.GetDbCnxStr(), Convert.ToInt32(Session["userId"]));
                    }
                    else
                    {
                        lbError.Text = "Necesitas estar loggeado para ver esto";

                    }
                    lbBusqueda.Text = "Mis productos";
                    break;

                default:
                    lbError.Text = "Parámetros incorrectos";

                    break;

            }



            return l;

        }


        protected void PopulateNewsItems(int? pageNo)
        {
            var dataSource = new PagedDataSource();

            // CHANGED THE ARRAY OF NEWSITEMS INTO A GENERIC LIST OF NEWSITEMS.
            dataSource.DataSource = obtenerLista();
            dataSource.AllowPaging = true;

            var pageSizeFromConfig = ConfigurationManager.AppSettings["NewsItemsPageCount"];
            var pageSize = 10;

            int.TryParse(pageSizeFromConfig, out pageSize);

            dataSource.PageSize = pageSize;
            dataSource.CurrentPageIndex = pageNo ?? 0;

            PagingPanel.Controls.Clear();
            for (var i = 0; i < dataSource.PageCount; i++)
            {
                var linkButton = new LinkButton();
                linkButton.CommandArgument = i.ToString();
                linkButton.CommandName = "PageNo";
                linkButton.Command += NavigationCommand;
                linkButton.ID = string.Format("PageNo{0}LinkButton", i);
                if (pageNo == i || (pageNo == null && i == 0))
                {
                    linkButton.Enabled = false;
                    linkButton.CssClass = "SelectedPageLink";
                }

                linkButton.Text = (i + 1).ToString();

                PagingPanel.Controls.Add(linkButton);
                if (i < (dataSource.PageCount - 1))
                    PagingPanel.Controls.Add(new LiteralControl("|"));
            }

            RPTproductosListados.DataSource = dataSource;
            RPTproductosListados.DataBind();
        }

        void NavigationCommand(object sender, CommandEventArgs e)
        {
            PopulateNewsItems(int.Parse((string)e.CommandArgument));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Listar.aspx?t=b&n=" + tbBuscar.Text);
        }
    }

}