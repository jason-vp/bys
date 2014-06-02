using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;
using BySLib.AUXILIAR;
using BySLib.BL;
using System.Web.Security;
using BySWeb.Utilities;
using BySLib.EN;


namespace BySWeb
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Mostramos cuadro de logging o bienvenida según existencia de la sesión
            if (Session["LoggedIn"] == null)
            {
                pnlLogin.Visible = true;
                pnlLogin.Enabled = true;
                pnlLStatus.Visible = false;
                pnlLStatus.Enabled = false;

            }
            else
            {
                pnlLogin.Visible = false;
                pnlLogin.Enabled = false;
                pnlLStatus.Visible = true;
                pnlLStatus.Enabled = true;
            }


            //comprobamos si existe la cookie para rellenar datos
            if (!IsPostBack)
            {
                if (Request.Cookies["myCookie"] != null)
                {
                    HttpCookie cookie = Request.Cookies.Get("myCookie");
                   Login1.UserName = cookie.Values["username"];


                    Login1.RememberMeSet = (!String.IsNullOrEmpty(Login1.UserName));
                }

            Response.Cache.SetNoStore();
            }
        }

        protected void Login1_LoggedIN(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("myCookie");
            Boolean remember = Login1.RememberMeSet;


            //añadimos cookie de 30 dias
            if (remember)
            {
                Int32 persistDays =30;
                myCookie.Values.Add("username", Login1.UserName);
                myCookie.Expires = DateTime.Now.AddDays(persistDays); 
            }

            Response.Cookies.Add(myCookie);
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool correcto=false;

            UsuarioEN user = UsuarioBL.GetUserByNick(Tools.GetDbCnxStr(), Login1.UserName);          
            correcto= PasswordHash.ValidatePassword(Login1.Password, user.Password);
           
            if (!correcto)
            {
                Login1.FailureText = "Usuario o contraseña incorrecta.";
            }
            else
            {

                Session["userNick"] = user.Nick;
                Session["userId"] = user.Id;
                Session["LoggedIn"] = "true";

                HttpCookie myCookie = new HttpCookie("myCookie");
                Boolean remember = Login1.RememberMeSet;


                //añadimos cookie de 30 dias
                if (remember)
                {
                    Int32 persistDays = 30;
                    myCookie.Values.Add("username", Login1.UserName);
                    myCookie.Expires = DateTime.Now.AddDays(persistDays);
                }

                Response.Cookies.Add(myCookie);

                
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }

        }
        protected void LoginStatus1_LoggedOut(Object sender, System.EventArgs e)
        {
            Session["userNick"] = null;
            Session["userId"] = null;
            Session["LoggedIn"] = null;
        }

    }
}
