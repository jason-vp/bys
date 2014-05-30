using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;
using BySLib.BL;
using BySLib.Utilities;
using BySWeb.Utilities;

namespace BySWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<ProductoEN> lProductosDestacados = /*ProductoBL.GetByDestacadosEN(Tools.GetDbCnxStr());*/null;
            List<ProductoEN> lUltimosProductos = null;

            //SubcategoriaEN sub = SubcategoriaBL.GetById(Tools.GetDbCnxStr(), 1); 
            
            if (lProductosDestacados != null)
            {
                RPTproductoDestacado.DataSource = lProductosDestacados;
                RPTproductoDestacado.DataBind();
            }
            if (lUltimosProductos != null)
            {
                RPTultimosProductos.DataSource = lUltimosProductos;
                RPTultimosProductos.DataBind();
            }
        }
    }
}