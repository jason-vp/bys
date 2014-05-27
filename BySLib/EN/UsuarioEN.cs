using System;
using BySLib;


namespace BySLib.EN
{

    /// <summary>
    /// Esta clase representa un Usuario de la aplicacion (Entidad de negocio)
    /// </summary>
    public class UsuarioEN : Object, IDisposable
    {

        #region IDisposable Members

        private bool disposed = false;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                }
            }
            this.disposed = true;
        }
        ~UsuarioEN()
        {
            this.Dispose(false);
        }

        #endregion

        #region Private Properties
        private string dni = "";
        private string password = "";
        private string nombre = "";
        private string apellidos = "";
        private DateTime fechaAlta;
        #endregion


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

     

    }
}
