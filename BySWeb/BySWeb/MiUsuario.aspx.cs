using System;
using System.Collections.Generic;
using System.Linq;
using BySLib.EN;
using BySLib.AUXILIAR;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BySLib.BL;
namespace BySWeb
{
    public partial class MiUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    //Obtencion en la variable id del id de usuario de la sesion actual
                    int id = Convert.ToInt32(Session["userId"]);
                    //Creacion de un objeto usuario con los datos del usuario de la BD
                    UsuarioEN user = UsuarioBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);
                    //Asignacion de los valores de los datos del usuario a los campos de texto del formulario.
                    tbNombre.Text = user.Nombre;
                    tbmail.Text = user.Mail;
                    tbDireccion.Text = user.Direccion;
                    Localidad.Text = user.Poblacion;
                    CP.Text = user.CodigoPostal.ToString();
                    tbtlf.Text = user.Telf.ToString();
                    tbmail.Text = user.Mail;
                    Label3.Text = user.Puntacion.ToString();
                    Label1.Text = user.Nick;
                    Credito.Text = user.Credito.ToString();
                    //lbError.Text = "";
                    //PnlError.Visible = false;
                    List<ProductoEN> misProductosPujados = ProductoBL.GetByPujadosIdPropietarioEN(Utilities.Tools.GetDbCnxStr(), id);
                    List<ProductoEN> misPoductosSobastardos = ProductoBL.GetByIdPropietarioEN(Utilities.Tools.GetDbCnxStr(), id);
                    List<ProductoEN> misProductosComprados = ProductoBL.GetByCompradosIdPropietarioEN(Utilities.Tools.GetDbCnxStr(), id);

                    if (misProductosPujados != null){

                        RPTproductosPujados.DataSource = misProductosPujados;
                        RPTproductosPujados.DataBind();
                    }
                    if (misPoductosSobastardos != null){

                        RPTproductosSobastardos.DataSource = misPoductosSobastardos;
                        RPTproductosSobastardos.DataBind();
                    }
                    if (misProductosComprados != null){

                        RPTproductosComprados.DataSource = misProductosComprados;
                        RPTproductosComprados.DataBind();
                    }

                }
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
                editarUser();
            }
            catch (Exception ex)
            {
                PnlError.Visible = true;
                lbError.Text = "Error Datos Incorrectos";

            }
        }

        //Función para editar un usuario existente.
        protected void editarUser()
        {
            int id = Convert.ToInt32(Session["userId"]);
            UsuarioEN user = UsuarioBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), id);
            //Se comprueba que el password introducido sea correcto antes de confirmar los cambios.
            if (PasswordHash.ValidatePassword(Contraseña_Actual.Text, user.Password))
            {
                    //sustitucion de los valores del objeto auxiliar con los datos del usuario de la BBDD
                    user.Nombre = tbNombre.Text;
                    user.Direccion = tbDireccion.Text;
                    user.Poblacion = Localidad.Text;
                    user.CodigoPostal = Int32.Parse(CP.Text);
                    user.Telf = Int32.Parse(tbtlf.Text);
                    user.Mail = tbmail.Text;
                    if (tbtlf.Text.Trim().Length != 9)
                    {
                        throw new Exception("Error Datos Incorrectos");
                    }
                    if (FileUpload1.HasFile)
                    {
                        FileUpload1.SaveAs(Server.MapPath(".") + @"/images/" + FileUpload1.FileName);
                    }
                    user.RutaImg = "/images/" + FileUpload1.FileName;
                    //Funcion de actualización de la BBDD.
                    UsuarioBL.UpdateFromEN(Utilities.Tools.GetDbCnxStr(), user);
            }
            else
            {
                Label4.Visible = true;
            }
        }
        //---------------------------------------------------------------------//
        //----------------------------VALIDACIONES-----------------------------//
        //---------------------------------------------------------------------//
        //Para más información sobre los criterios de validacion ir a la clase Validacion.

        //Validacion del nombre de usuario
        protected void ComprobarNombre(object sender, ServerValidateEventArgs e)
        {
            string nombre = e.Value;

            if (!Validacion.isNombre(nombre))
            {
                e.IsValid = false;
            }
        }
        //Validación del teléfono
        protected void ComprobarTelefono(object sender, ServerValidateEventArgs e)
        {
            string telefono = e.Value;

            if (!Validacion.isTelefono(telefono))
            {
                e.IsValid = false;
            }
        }
        //Validacion de la dirección
        protected void ComprobarDireccion(object sender, ServerValidateEventArgs e)
        {
            string direccion = e.Value;

            if (!Validacion.isDireccion(direccion))
            {
                e.IsValid = false;
            }
        }
        //Validacion del mail
        protected void ComprobarEmail(object sender, ServerValidateEventArgs e)
        {
            string email = e.Value;

            if (!Validacion.isEmail(email))
            {
                e.IsValid = false;
            }

        }

        //Validacion del password actual
        protected void ComprobarPassword(object sender, ServerValidateEventArgs e)
        {
            string pass = e.Value;

            if (!Validacion.isPassword(pass))
            {
                e.IsValid = false;
            }

        }
        //Validacion de password nuevo
        protected void ComprobarPassword2(object sender, ServerValidateEventArgs e)
        {
            string pass = e.Value;
            if (tbcontrasenyanueva.Text != "")
            {
                if (!Validacion.isPassword(pass))
                {
                    e.IsValid = false;
                }
            }
        }
    }

}