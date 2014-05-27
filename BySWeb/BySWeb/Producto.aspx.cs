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
        { }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            /* ProductoEN productoActual = new ProductoEN();

             float pujaActuaWeb = float.Parse(LblPujaActual.Text);
                

             int id = Int32.Parse(Request.QueryString["id"]);

             productoActual.getProductoById(id);

             PujaEN pujaActual = productoActual.getUltimaPuja();
             float mostrar = pujaActual.Valor;

             if(mostrar == -1{
               
                 mostrar = productoActual.PrecioSalida;
             }
             if(mostrar != pujaActuaWeb){

                 LblPujaActual.Text = mostrar.ToString();
             */
        }
    }
}