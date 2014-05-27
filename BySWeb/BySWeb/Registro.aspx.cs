using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                if (TextB_CP.Text.Trim().Length != 5)
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception ex)
            {

                PnlError.Visible = true;
                lbError.Text = "error";
            }

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