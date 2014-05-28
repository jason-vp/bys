using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;

namespace BySWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<ProductoEN> lProductosDestacados = null;
            List<ProductoEN> lUltimosProductos = null;



            RPTproductoDestacado.DataSource = lProductosDestacados;
            RPTproductoDestacado.DataBind();

            RPTultimosProductos.DataSource = lUltimosProductos;
            RPTultimosProductos.DataBind();
        }
    }
}