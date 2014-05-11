using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BySWeb
{
    public partial class MiUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lbError.Text = "";
                PnlError.Visible = false;
            }
            catch (Exception ex)
            { 
            
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Boton_Editar_Datos_Click(object sender, EventArgs e)
        {
            try
            {
                if(Telefono.Text.Trim().Length !=9)
                {
                    throw new Exception("Error Datos Incorrectos");
                }
            }
            catch (Exception ex)
            {
                PnlError.Visible = true;
                lbError.Text = "Error Datos Incorrectos";
            
            }
        }
    }
}