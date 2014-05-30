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


namespace BySWeb
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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


        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool correcto=false;

            string hash = UsuarioBL.GetUserHash(Tools.GetDbCnxStr(), Login1.UserName);
            if (hash == "NO")
                correcto = false;
            else
            correcto= PasswordHash.ValidatePassword(Login1.Password, hash);
           
            if (!correcto)
            {
                Login1.FailureText = "Usuario o contraseña incorrecta.";
            }
            else
            {

                Session["nick"] = Login1.UserName;
                
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }

            

        }
        
    }
}
