using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;
using BySLib.BL;
using BySWeb.Utilities;
namespace BySWeb
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                //Informacion sobre el producto de la interfaz de producto.
            int id = Int32.Parse(Request.QueryString["id"]);
            ProductoEN prod= ProductoBL.GetByIdToEN(Tools.GetDbCnxStr(),id);
            lblNombreProd.Text=prod.Nombre;
            lblDescripcion.Text=prod.Descripcion;
            lblCantidadRest.Text=prod.CantidadRestante.ToString();
            fechaFinProducto.Text=prod.FechaFin.ToString();
            EstadoProducto.Text = prod.Estado;
            PujaEN ultimaPuja = PujaBL.GetLastPujaByProductoId(Tools.GetDbCnxStr(), id);
            lblPujaActual.Text= ultimaPuja.Valor.ToString();
            lblPrecio.Text=prod.PrecioCompra.ToString();
            imgProducto.ImageUrl = prod.Fotos[0].Ruta;
              //Barra lateral información del usuario propietario del producto
            UsuarioEN user = UsuarioBL.GetByIdToEN(Tools.GetDbCnxStr(), id);
            lblNombreProp.Text = user.Nombre.ToString();
            lblPuntUser.Text=user.Puntacion.ToString();
            imgUsuario.ImageUrl=user.RutaImg;

        
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            ProductoEN productoActual = ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);            
            
            PujaEN pujaActual = PujaBL.GetLastPujaByProductoId(Utilities.Tools.GetDbCnxStr(), productoActual.Id);
            decimal mostrar = pujaActual.Valor;

            if(mostrar == -1){

                mostrar = productoActual.PrecioSalida;
            }
            else{

                lblPujaActual.Text = mostrar.ToString();
            }
        }
    }
}