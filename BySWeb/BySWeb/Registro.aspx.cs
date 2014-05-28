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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lbError.Text = "";
                PnlError.Visible = false;

               

                if (!this.IsPostBack)
                {


                    this.TextB_CP.Text = "000000";

                }
            }
            catch (Exception ex)
            {
                
                
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (UsuarioEN us = this.getUsuario()) {

                    UsuarioBL.CreateFromEN(Tools.GetDbCnxStr(), us);
                
                }
            }
            catch (Exception ex)
            {

                PnlError.Visible = true;
                lbError.Text = "error";
            }

        }

        private UsuarioEN getUsuario()
        {
            //filtrar validatedata

            return new UsuarioEN
            {
                Nombre = this.TextB_Nombre.Text.Trim(),
                Nick = this.TextB_Usuario.Text.Trim(),
                Mail = TextB_mail.Text.Trim(),
                Password = TextB_Contraseña.Text.Trim(),
                Telf = Convert.ToInt32(TextB_tlf.Text.Trim()),
                Direccion = TextBox2.Text.Trim()
            };
        }

        protected void TextB_CP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextB_CP.Text.Trim().Length != 5)
                {
                    throw new Exception("Error");
                }
                else {

                    TextB_CP.Text = "12345";
                }
            }
            catch (Exception ex)
            {

                PnlError.Visible = true;
                lbError.Text = "error";
            }
        }

    }
}