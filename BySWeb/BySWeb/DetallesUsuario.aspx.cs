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
            //Obtiene el usuario de la sesión actual
            int id = Int32.Parse(Request.QueryString["id"]);
            // Crea un objeto usuarioEN con los datos del usuario de la sesión actual
            UsuarioEN user = UsuarioBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(),id);
            //Rellena los campos del formulario con los datos del usuario
            lblNick.Text = user.Nick;
            emailDetUsuario.Text = user.Mail;
            localidadDetUsuario.Text = user.Poblacion;
            puntuacionDetallesUsuario.Text = user.Puntacion.ToString();
            userLogo.ImageUrl = user.RutaImg;
        }
    }
}