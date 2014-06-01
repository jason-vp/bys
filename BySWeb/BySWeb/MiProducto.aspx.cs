using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;
using BySLib.BL;

namespace BySWeb
{
    public partial class MiProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try 
            {

                int id = Int32.Parse(Request.QueryString["id"]);
                ProductoEN prod = ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);
                tbNombreProducto.Text = prod.Nombre;
                tbDescripcion.Text = prod.Descripcion;
                tbPrecioSalida.Text = prod.PrecioSalida.ToString();
                tbCompra.Text = prod.PrecioCompra.ToString();
                tbCantidadRestante.Text = prod.CantidadRestante.ToString();
                ImageProducto.ImageUrl = prod.Fotos[0].Ruta;
                SubcategoriaEN subcat = SubcategoriaBL.GetById(Utilities.Tools.GetDbCnxStr(), prod.Subcategoria );
                CategoriaEN cat = CategoriaBL.GetAll(Utilities.Tools.GetDbCnxStr(), subcat.Padre);
                
               
               
                if (prod.PrecioCompra == -1)
                {
                    tbCompra.Text = "";
                    chkCompraInmediata.Checked = false;

                }
                else
                {
                    chkCompraInmediata.Checked = true;
                    tbCompra.Text=prod.PrecioCompra.ToString();
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
            prod.PrecioSalida = Int32.Parse(tbPrecioSalida.Text);
            prod.PrecioCompra = Int32.Parse(tbCompra.Text);
            prod.CantidadRestante = Int32.Parse(tbCantidadRestante.Text);
            //prod.Fotos=
            //funcion de edición en la bd a partir del objeto EN
            ProductoBL.UpdateFromEN(Utilities.Tools.GetDbCnxStr(), prod);
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