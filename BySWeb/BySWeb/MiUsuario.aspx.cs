using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.EN;
namespace BySWeb
{
    public partial class MiUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //int id = Int32.Parse(Request.QueryString["id"]);
                //UsuarioEN user=new UsuarioEN(id);
                //Nombre.Text=user.Nombre;
                //Direccion.Text=user.Direccion;
                //PoblacionEN pob= new PoblacionEN(user.CodigoPostal, user.Poblacion);
                //ProvinciaEN prov = new ProvinciaEN(pob.Cod_provincia);
                //Provincia.Text=prov.nom_prov;
                //Localidad.Text = pob.Nombre;
                //CP.Text = user.CodigoPostal;
                //Telefono.Text = user.Telf;
                //Usuario.Text = user.Nick;
                //Email.Text = user.Mail;
                //Label1.Text = user.Puntacion;
                //Contraseña_Actual.Text = user.Password;
                //Credito.Text = user.Credito;

                //lbError.Text = "";
                //PnlError.Visible = false;
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