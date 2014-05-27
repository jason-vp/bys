using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;
namespace BySWeb
{
    public partial class DetallesUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            UsuarioEN user = new UsuarioEN(id);
            nickDetUsuario.Text = user.Nick;
            emailDetUsuario.Text = user.Mail;
            PoblacionEN pob= new PoblacionEN(user.CodigoPostal, user.Poblacion);
            localidadDetUsuario.Text = pob.Nombre;
            puntuacionDetallesUsuario.Text = user.Puntacion;
            userLogo.ImageUrl = user.rutaImg;

 

        }
    }
}