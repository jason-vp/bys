using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;
using BySLib.BL;
using BySLib.AUXILIAR;
using BySWeb.Utilities;

namespace BySWeb
{
    public partial class MiProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {

                    if (Request.QueryString["id"] != null)
                    {

                        int id = Int32.Parse(Request.QueryString["id"]);
                        ProductoEN prod = ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);
                        tbNombreProducto.Text = prod.Nombre;
                        tbDescripcion.Text = prod.Descripcion;
                        tbPrecioSalida.Text = prod.PrecioSalida.ToString();
                        tbCompra.Text = prod.PrecioCompra.ToString();
                        tbCantidadRestante.Text = prod.CantidadRestante.ToString();
                        ImageProducto.ImageUrl = prod.Foto;
                        SubcategoriaEN subcat = SubcategoriaBL.GetById(Utilities.Tools.GetDbCnxStr(), prod.Subcategoria);
                        CategoriaEN cat = CategoriaBL.GetById(Utilities.Tools.GetDbCnxStr(), subcat.Padre);
                        tbFecha.Text = prod.FechaFin.ToString();
                        lbcategoria.Text = cat.Nombre;
                        lbSubcategoria.Text = subcat.Nombre;

                        if (prod.PrecioCompra == -1)
                        {
                            tbCompra.Text = "";
                            chkCompraInmediata.Checked = false;

                        }
                        else
                        {
                            chkCompraInmediata.Checked = true;
                            tbCompra.Text = prod.PrecioCompra.ToString();
                        }
                        if (prod.Estado == "Inactivo") Btn_Editar.Visible = true;
                        else LabelErrorEstado.Visible = true;
                    }
                    else
                    {
                        Btn_Crear.Visible = true;
                        ddpSubcategoria.Visible = true;
                        tbNombreProducto.Text = "prueba";
                        ddpSubcategoria.Items.Clear();
                        List<SubcategoriaEN> subcats = SubcategoriaBL.GetAll(Tools.GetDbCnxStr());
                        List<CategoriaEN> cats = CategoriaBL.GetAll(Tools.GetDbCnxStr());
                        foreach (SubcategoriaEN s in subcats)
                        {

                            ddpSubcategoria.Items.Add(new ListItem(cats[s.Padre - 1].Nombre + " - " + s.Nombre, s.Id.ToString()));
                        }

                    }
                }

                //if(!IsPostBack)
            }
            catch (Exception ex)
            {

            }
        }

        //Función para editar un producto desde la interfaz de MiProducto
        protected void editar()
        {
            //Creación de objeto  con los datos modificados
            ProductoEN prod = ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), Int32.Parse(Request.QueryString["id"]));
            prod.Nombre = tbNombreProducto.Text;
            prod.Descripcion = tbDescripcion.Text;
            prod.PrecioSalida = Convert.ToDecimal(tbPrecioSalida.Text);
            prod.PrecioCompra = Convert.ToDecimal(tbCompra.Text);
            prod.CantidadRestante = Convert.ToInt32(tbCantidadRestante.Text);

            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath(".") + @"/images/" + FileUpload1.FileName);
                prod.Foto = "/images/" + FileUpload1.FileName;
            }


            //funcion de edición en la bd a partir del objeto EN
            ProductoBL.UpdateFromEN(Utilities.Tools.GetDbCnxStr(), prod);
        }

        protected void Btn_Editar_Click(object sender, EventArgs e)//revisar
        {
            //if (Page.IsValid)
            //{
            editar();
            //}
        }

        protected void crear()
        {
            if (Session["LoggedIn"] == "true")
            {

                ProductoEN prod = new ProductoEN();
                prod.Nombre = tbNombreProducto.Text;
                prod.Descripcion = tbDescripcion.Text;
                prod.PrecioSalida = Int32.Parse(tbPrecioSalida.Text);
                prod.PrecioCompra = Int32.Parse(tbCompra.Text);
                prod.CantidadRestante = Int32.Parse(tbCantidadRestante.Text);
                prod.Estado = "Activo";
                prod.Propietario = Convert.ToInt32(Session["userId"]);

                prod.Subcategoria = 1;
                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(Server.MapPath(".") + @"/images/" + FileUpload1.FileName);
                    prod.Foto = "/images/" + FileUpload1.FileName;
                }

                prod.Subcategoria = Convert.ToInt32(ddpSubcategoria.SelectedValue);
                ProductoBL.Create(Utilities.Tools.GetDbCnxStr(), prod);
            }
            else
            {
                LabelErrorEstado.Text = "Necesitas estar logeado";

            }

        }
        //---------------------------------------------------------------------//
        //----------------------------VALIDACIONES-----------------------------//
        //---------------------------------------------------------------------//
        //Para más información sobre los criterios de validacion ir a la clase Validacion.

        //Validacion del nombre de usuario
        protected void ComprobarNombre(object sender, ServerValidateEventArgs e)
        {
            string nombre = e.Value;

            if (!Validacion.isNombreDescProd(nombre))
            {
                e.IsValid = false;
            }
            else
                e.IsValid = true;
        }
        //Validación dela descripcion
        protected void ComprobarDescripcion(object sender, ServerValidateEventArgs e)
        {
            string desc = e.Value;

            if (!Validacion.isNombreDescProd(desc))
            {
                e.IsValid = false;
            }
        }
        //Validacion del precio de salida.
        protected void ComprobarNumero(object sender, ServerValidateEventArgs e)
        {
            string precio = e.Value;

            if (!Validacion.isNumero(precio))
            {
                e.IsValid = false;
            }
        }

        protected void Btn_Crear_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                crear();
            }
        }
        //protected void TextBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //protected void Nombre_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void tbNombreProducto_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}