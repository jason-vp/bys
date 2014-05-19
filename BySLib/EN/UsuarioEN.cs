using System;
using BySLib;


namespace BySLib.EN
{

    /// <summary>
    /// Esta clase representa un Usuario de la aplicacion (Entidad de negocio)
    /// </summary>
    class UsuarioEN
    {

        #region Private Properties
        private string dni = "";
        private string password = "";
        private string nombre = "";
        private string apellidos = "";
        private DateTime fechaAlta;
        #endregion

        /// <summary>
        /// Obtiene todos los usuarios de la DB
        /// </summary>
        /// <returns>Devuelve un array de Usuario con todos los usuarios leidos de la DB</returns>
        static public UsuarioEN[] getUsuario()
        {
            // Lee los usuarios de la DB y los devuelve
            return UsuarioCAD.obtenerTodosUsuarios();
        }

        /// <summary>
        /// Obtiene un usuario a traves de su dni
        /// </summary>
        /// <param name="dni">El dni del usuario que se devolvera</param>
        /// <returns>Devuelve en Usuario cuyo dni se pasó por parámetro</returns>
        static public UsuarioEN getUsuario(string dni)
        {
            // busca el usuario por el DNIen la DB
            return null;// UsuarioCAD.obtenerUsuarioDni(dni);
        }

        // <summary>
        /// Comprueba si un usuario existe en la DB
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool esUsuario(string dni, string password)
        {
            return UsuarioCAD.esUsuario(dni, password);
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="dni">El DNI del usuario</param>
        /// <param name="password">La contraseña del usuario</param>
        /// <param name="nombre">El nombre del usuario</param>
        /// <param name="apellidos">Los apellidos del usuario</param>
        
        public UsuarioEN(string dni, string password, string nombre, string apellidos)
        {
       
            this.dni = dni;
            
            this.password = password;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaAlta = DateTime.Now;
            
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="dni">El DNI del usuario</param>
        /// <param name="password">La contraseña del usuario</param>
        /// <param name="nombre">El nombre del usuario</param>
        /// <param name="apellidos">Los apellidos del usuario</param>
        /// <param name="fechaAlta">Fecha de alta de usuario en el sistema</param>
        /// <param name="rol">El rol o nivel de acceso del usuario</param>
        public UsuarioEN(string dni, string password, string nombre, string apellidos, string fechaAlta)
        {

            this.dni = dni;     
            this.password = password;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaAlta = DateTime.Parse(fechaAlta);
            
        }

        #region Getter y Setters

        /// <summary>
        /// Obtiene el DNI del usuario actual
        /// </summary>
        /// <returns>Devuelve el DNI</returns>
        public string getDni()
        {
            return dni;
        }
     

        /// <summary>
        /// Obtiene la contraseña del usuario
        /// </summary>
        /// <returns>Devuelve la contraseña</returns>
        public string getPassword()
        {
            return password;
        }

        /// <summary>
        /// Obtiene el nombre del Usuario actual
        /// </summary>
        /// <returns>Devuelve el nombre</returns>
        public string getNombre()
        {
            return nombre;
        }

        /// <summary>
        /// Obtiene los apellidos del usuario del Usuario actual
        /// </summary>
        /// <returns>Devuelve los apellidos</returns>
        public string getApellidos()
        {
            return apellidos;
        }

        /// <summary>
        /// Obtiene la fecha de alta del Usuario actual
        /// </summary>
        /// <returns>Devuelve la fecha de alta</returns>
        public DateTime getFechaAlta()
        {
            return fechaAlta;
        }

   
        /// <summary>
        /// Cambia el password del Usuario actual
        /// </summary>
        /// <param name="password">Es el nuevo password</param>
        public void setPassword(string password)
        {
            this.password = password;
        }

        /// <summary>
        /// Cambia el nombre del usuario actual
        /// </summary>
        /// <param name="nombre">Es el nuevo nombre</param>
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Cambia los apellidos del usuario actual
        /// </summary>
        /// <param name="apellidos">Son los nuevos apellidos</param>
        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        #endregion

        /// <summary>
        /// Confirma los cambios del Usuario en la DB. Inserta o modifica.
        /// </summary>
        /// <returns>Devuelve true si se llevó a cabo la insercion/acatualizacion o false en caso contrario</returns>
        public bool commitDB()
        {
            // Inserta en la DB si no existe y lo actualiza si ya existía
           // UsuarioCAD cad = new UsuarioCAD(this);
            return false;// cad.insertarActualizar();
        }

        /// <summary>
        /// Borra el Usuario actual de la DB
        /// </summary>
        /// <returns>Devuelve true si se borró con éxito o false en caso contrario</returns>
        public bool borrarDB()
        {
            // Borra el usuario actual de la DB
           // UsuarioCAD cad = new UsuarioCAD(this);
            return false;// cad.borrar();
        }

    }
}
