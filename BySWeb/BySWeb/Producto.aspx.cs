using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;
namespace BySWeb
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //    //Informacion sobre el producto de la interfaz de producto.
            //int id = Int32.Parse(Request.QueryString["id"]);
            //ProductoEN prod=new ProductoEN(id);
            //lblNombreProd.Text=prod.Nombre;
            //lblDescripcion.Text=prod.Descripcion;
            //lblCantidadRest.Text=prod.CantidadRestante.ToString();
            //fechaFinProducto.Text=prod.FechaFin.ToString();
            //EstadoProducto.Text = prod.Estado;
            //lblPujaActual.Text=prod.pujaMayor().toString();
            //lblPrecio.Text=prod.PrecioCompra.ToString();
            //imgProducto.ImageUrl = prod.Fotos[0].Ruta;
            //    //Barra lateral información del usuario propietario del producto
            //UsuarioEN user = new UsuarioEN(prod.Propietario);
            //lblNombreProp.Text = user.Nombre.ToString();
            //lblPuntUser.Text=user.Puntacion.ToString();
            //imgUsuario.ImageUrl=user.RutaImg;
        
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //ProductoEN productoActual = new ProductoEN();

            //float pujaActuaWeb = float.Parse(lblPujaActual.Text);


            //int id = Int32.Parse(Request.QueryString["id"]);

            //productoActual.GetById(id);
            //PujaEN pujaActual = productoactual.getultimapuja();
            //float mostrar = pujaactual.valor;

            //if(mostrar == -1{

            //    mostrar = productoactual.preciosalida;
            //}
            //if(mostrar != pujaactuaweb){

            //    lblPujaActual.Text = mostrar.ToString;
            //}
        }
    }
}