﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BySLib.EN;
using BySLib.AUXILIAR;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace BySWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                lbError.Text="";
                PnlError.Visible=false;
            }
            catch(Exception ex)
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
                if (TextB_tlf.Text.Trim().Length != 9)
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception ex) {

                PnlError.Visible = true;
                lbError.Text = "error";
            }

        }

        protected void TextB_CP_TextChanged(object sender, EventArgs e)
        {
            if (TextB_CP.Text.Length == 5){

               //llamada a la funcion AJAX
                rellenaLocProv(Int32.Parse(TextB_CP.Text));
            }
            
        }

        protected void ComprobarUsuario(object sender, ServerValidateEventArgs e)
        {
            string nombre = e.Value;

            if (!Validacion.isNombre(nombre))
            {
                e.IsValid = false;
            }
        }

        protected void ComprobarTelefono(object sender, ServerValidateEventArgs e)
        {
            string telefono = e.Value;

            if (!Validacion.isTelefono(telefono))
            {
                e.IsValid = false;
            }
        }

        protected void ComprobarDireccion(object sender, ServerValidateEventArgs e)
        {
            string direccion = e.Value;

            if (!Validacion.isDireccion(direccion))
            {
                e.IsValid = false;
            }
        }

        protected void ComprobarCpostal(object sender, ServerValidateEventArgs e)
        {
            string cp = e.Value;

            if (!Validacion.isCpostal(cp))
            {
                e.IsValid = false;
            }
        }

        protected void ComprobarEmail(object sender, ServerValidateEventArgs e)
        {
            string email = e.Value;

            if (!Validacion.isEmail(email))
            {
                e.IsValid = false;
            }
        }

        protected void ComprobarPassword(object sender, ServerValidateEventArgs e)
        {
            string pass = e.Value;

            if (!Validacion.isPassword(pass))
            {
                e.IsValid = false;
            }
        }

        protected void ComprobarLocalidad(object sender, ServerValidateEventArgs e)
        {
            string localidad = e.Value;

            if (localidad == "")
            {
                e.IsValid = false;
            }
        }

        protected void ComprobarProvincia(object sender, ServerValidateEventArgs e)
        {
            string provincia = e.Value;

            if (provincia == "0")
            {
                e.IsValid = false;
            }
        }
    pro
        protected void rellenaLocProv(int CP){
        
            private List<P> customers; 
        }
        /**
        protected void list_provincia_DataBound(object sender, EventArgs e)
        {
            list_provincia.Items.Insert(0, new ListItem("", "0"));
        }
        **/
    }
}