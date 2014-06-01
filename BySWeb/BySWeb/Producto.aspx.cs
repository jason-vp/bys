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

            if (!IsPostBack)
            {
                pnlError.Visible = false;
                //Informacion sobre el producto de la interfaz de producto.
                int id = Int32.Parse(Request.QueryString["id"]);
                ProductoEN prod = ProductoBL.GetByIdToEN(Tools.GetDbCnxStr(), id);
                lblNombreProd.Text = prod.Nombre;
                lblDescripcion.Text = prod.Descripcion;
                lblCantidadRest.Text = prod.CantidadRestante.ToString();
                fechaFinProducto.Text = prod.FechaFin.ToString();
                EstadoProducto.Text = prod.Estado;
                PujaEN ultimaPuja = PujaBL.GetLastPujaByProductoId(Tools.GetDbCnxStr(), id);
                lblPujaActual.Text = ultimaPuja.Valor.ToString();
                lblPrecio.Text = prod.PrecioCompra.ToString();
                imgProducto.ImageUrl = prod.Fotos[0].Ruta;
                //Barra lateral información del usuario propietario del producto
                UsuarioEN user = UsuarioBL.GetByIdToEN(Tools.GetDbCnxStr(), id);
                lblNombreProp.Text = user.Nombre.ToString();
                lblPuntUser.Text = user.Puntacion.ToString();
                imgUsuario.ImageUrl = user.RutaImg;
                /*
                List<CategoriaEN> ls = new List<CategoriaEN>();
                ls = CategoriaBL.GetAll(Tools.GetDbCnxStr());
                foreach (CategoriaEN c in ls) {
                    DropDownList1.Items.Add(c);            
                }*/
                List<CompraEN> comentariosProducto = CompraBL.GetByIdProductoToEN(Tools.GetDbCnxStr(), id);

                if (comentariosProducto != null)
                {
                    RPTcomentariosProducto.DataSource = comentariosProducto;
                    RPTcomentariosProducto.DataBind();
                }

            }
            else {

                pnlError.Visible = true;
            
            }
        
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

        protected void btnPuja_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(Request.QueryString["id"]);
            ProductoEN productoActual = ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);

            PujaEN ultimaPuja = PujaBL.GetLastPujaByProductoId(Utilities.Tools.GetDbCnxStr(), productoActual.Id);
            decimal tbPujaTexto = decimal.Parse(tbPuja.Text);

            if (tbPujaTexto >= ultimaPuja.Valor){
                pnlError.Visible = false;

                ultimaPuja.Valor = tbPujaTexto;
                ultimaPuja.Propietario = Convert.ToInt32(Session["userId"]);
                ultimaPuja.Fecha = System.DateTime.Now;
                PujaBL.CreateFromEN(Tools.GetDbCnxStr(), ultimaPuja);

            }
            else{
                lbError.Text = "Tu puja es menor que la puja vigente. Utiliza el boton de refrescar para obtener la puja más reciente";
                //Mostrar mensaje de error para decirle al usuario que refresque la ultima puja y que introduzca una nueva
            }

        }
    }
}