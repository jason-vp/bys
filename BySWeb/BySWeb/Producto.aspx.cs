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
                PujaEN ultimaPuja = PujaBL.GetLastPujaByProductoId(Tools.GetDbCnxStr(), id);

                //finalizar puja si ha llegado la fecha, poniendola inactiva o comprada
                //según la situación
                if (DateTime.Now >= prod.FechaFin && prod.Estado == "Activo")
                {
                    if (ultimaPuja.Propietario != -1)
                    {
                        CompraEN compra = new CompraEN();
                        compra.Comentario = "";
                        compra.Eliminado = false;
                        compra.Fecha = DateTime.Now;
                        compra.Producto = prod.Id;
                        compra.Pujador = ultimaPuja.Propietario;
                        compra.Puntuacion = 4;
                        UsuarioEN comprador = UsuarioBL.GetByIdToEN(Tools.GetDbCnxStr(), ultimaPuja.Propietario);
                        comprador.Credito -= ultimaPuja.Valor;
                        UsuarioBL.UpdateFromEN(Tools.GetDbCnxStr(), comprador);
                        CompraBL.Create(Tools.GetDbCnxStr(), compra);
                        prod.Estado = "Vendido";
                        ProductoBL.UpdateFromEN(Tools.GetDbCnxStr(), prod);

                    }
                    else
                    {
                        prod.Estado = "Inactivo";
                        ProductoBL.UpdateFromEN(Tools.GetDbCnxStr(), prod);
                    }
                }

                lblNombreProd.Text = prod.Nombre;
                lblDescripcion.Text = prod.Descripcion;
                lblCantidadRest.Text = prod.CantidadInicial.ToString();
                fechaFinProducto.Text = prod.FechaFin.ToString();
                EstadoProducto.Text = prod.Estado;
                
                decimal valor = ultimaPuja.Valor;
                if (valor == 0)
                    valor = prod.PrecioSalida;
                lblPujaActual.Text = valor.ToString();
                lblPrecio.Text = prod.PrecioCompra.ToString();
                imgProducto.ImageUrl = prod.Foto;
                //Barra lateral información del usuario propietario del producto
                UsuarioEN user = UsuarioBL.GetByIdToEN(Tools.GetDbCnxStr(), prod.Propietario);
                hLinkDetallesUsuario.NavigateUrl = "/DetallesUsuario.aspx?id=" + prod.Propietario;
                imgUsuario.ImageUrl = "/DetallesUsuario.aspx?id=" + prod.Propietario;
                if (prod.Estado == "Comprado" || prod.Estado == "Inactivo")
                {
                    btnCompra.Visible = false;
                    btnPuja.Visible = false;
                }

                lblNombreProp.Text = user.Nick.ToString();
                lblPuntUser.Text = user.Puntacion.ToString();
                imgUsuario.ImageUrl = user.RutaImg;
                if (Session["LoggedIn"] != null && prod.Propietario == Convert.ToInt32(Session["userId"]))
                {
                    hMiProducto.NavigateUrl = "/MiProducto.aspx?id=" + prod.Id;
                    lbMiProducto.Text = "Editar Mi Producto";
                    hMiProducto.Visible = true;
                    lbMiProducto.Visible = true;

                }
                else
                {
                    hMiProducto.Visible = false;
                    lbMiProducto.Visible = false;
                }
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
            else
            {

                pnlError.Visible = true;

            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            ProductoEN productoActual = ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);

            PujaEN pujaActual = PujaBL.GetLastPujaByProductoId(Utilities.Tools.GetDbCnxStr(), productoActual.Id);
            decimal mostrar = pujaActual.Valor;

            if (mostrar == -1 || mostrar == 0)
            {

                mostrar = productoActual.PrecioSalida;
            }
            else
            {

                lblPujaActual.Text = mostrar.ToString();
            }
        }

        protected void btnPuja_Click(object sender, EventArgs e)
        {

            try
            {
                pnlError.Visible = false;
                int id = Int32.Parse(Request.QueryString["id"]);
                ProductoEN productoActual = ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);

                PujaEN ultimaPuja = PujaBL.GetLastPujaByProductoId(Utilities.Tools.GetDbCnxStr(), productoActual.Id);
                decimal ultimaPu = ultimaPuja.Valor;
                decimal tbPujaTexto = decimal.Parse(tbPuja.Text);

                if (Session["LoggedIn"] == "true")
                {
                    UsuarioEN user = UsuarioBL.GetByIdToEN(Tools.GetDbCnxStr(), Convert.ToInt32(Session["userId"]));

                    if (user.Id == ultimaPuja.Propietario)
                    {
                        pnlError.Visible = true;
                        lbError.Text = "La ultima puja ya es tuya";
                    }
                    else
                    {


                        if (user.Credito >= tbPujaTexto)
                        {
                            if (ultimaPu == 0)
                                ultimaPu = productoActual.PrecioSalida;
                            if (tbPujaTexto > ultimaPu)
                            {
                                pnlError.Visible = false;
                                ultimaPuja.Producto = productoActual.Id;
                                ultimaPuja.Estado = "Mejor";
                                ultimaPuja.Valor = tbPujaTexto;
                                ultimaPuja.Propietario = Convert.ToInt32(Session["userId"]);
                                ultimaPuja.Fecha = System.DateTime.Now;
                                PujaBL.CreateFromEN(Tools.GetDbCnxStr(), ultimaPuja);


                            }
                            else
                            {
                                pnlError.Visible = true;
                                lbError.Text = "Tu puja es menor que la puja vigente. Utiliza el boton de refrescar para obtener la puja más reciente";
                            }
                        }
                        else
                        {
                            pnlError.Visible = true;
                            lbError.Text = "No tienes suficiente credito";
                        }
                    }
                }
                else
                {
                    pnlError.Visible = true;
                    lbError.Text = "Debes estar Logueado para pujar";

                    //Mostrar mensaje de error para decirle al usuario que refresque la ultima puja y que introduzca una nueva
                }

            }
            catch (Exception ex)
            {

            }


        }

        protected void btnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                ProductoEN productoActual = ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);

                pnlError.Visible = false;


                decimal compraTexto = productoActual.PrecioCompra;

                if (Session["LoggedIn"] == "true")
                {
                    UsuarioEN user = UsuarioBL.GetByIdToEN(Tools.GetDbCnxStr(), Convert.ToInt32(Session["userId"]));

                    if (user.Credito >= compraTexto)
                    {

                        CompraEN compra = new CompraEN();

                        compra.Fecha = System.DateTime.Now;
                        compra.Producto = productoActual.Id;
                        compra.Pujador = Convert.ToInt32(Session["userId"]);
                        //creo la compra
                        CompraBL.Create(Tools.GetDbCnxStr(), compra);
                        //actualizo el producto
                        productoActual.Estado = "Vendido";
                        ProductoBL.UpdateFromEN(Tools.GetDbCnxStr(), productoActual);



                        PnlPuja.Enabled = false;
                        PnlCompra.Enabled = false;
                        pnlError.Visible = true;
                        lbError.Text = "Compra realizada";


                    }
                    else
                    {
                        pnlError.Visible = true;
                        lbError.Text = "No tienes suficiente credito";
                    }
                }
                else
                {
                    pnlError.Visible = true;
                    lbError.Text = "Debes estar Logueado para comprar";

                    //Mostrar mensaje de error para decirle al usuario que refresque la ultima puja y que introduzca una nueva
                }


            }
            catch (Exception ex)
            {

            }

        }
    }
}