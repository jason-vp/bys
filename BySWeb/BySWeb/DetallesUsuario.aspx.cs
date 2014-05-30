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
    public partial class DetallesUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            UsuarioEN user = UsuarioBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(),id);
            lblNick.Text = user.Nick;
            emailDetUsuario.Text = user.Mail;
            localidadDetUsuario.Text = user.Poblacion;
            puntuacionDetallesUsuario.Text = user.Puntacion.ToString();
            userLogo.ImageUrl = user.RutaImg;
        }
    }
}