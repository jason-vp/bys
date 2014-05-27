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
        private int id = -1;
        private string nick = "";
        private int telf = 0;
        private string direccion = "";
        private decimal credito = 0;
        private decimal puntacion = 0;
        private int puntuacionTotal = 0;
        private int numeroVotos = 0;
        private int codigoPostal = 0;
        private string poblacion = "";
        private bool eliminado = false;
        private string mail = "";
        private string password = "";
        private string nombre = "";

        #endregion


        #region Getter y Setters

        /// <summary>
        /// Atributo ID de usuario + getter/setter
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Atributo nick de usuario + getter/setter
        /// </summary>
        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }

        /// <summary>
        /// Atributo telefono de usuario + getter/setter
        /// </summary>
        public int Telf
        {
            get { return telf; }
            set { telf = value; }
        }

        /// <summary>
        /// Atributo dirección de usuario + getter/setter
        /// </summary>
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        /// <summary>
        /// Atributo Credito de usuario + getter/setter
        /// </summary>
        public decimal Credito
        {
            get { return credito; }
            set { credito = value; }
        }

        /// <summary>
        /// Atributo puntuacion de usuario + getter/setter
        /// </summary>
        public decimal Puntacion
        {
            get { return puntacion; }
            set { puntacion = value; }
        }
        /// <summary>
        /// Atributo puntuacion total de usuario + getter/setter
        /// </summary>
        public int PuntuacionTotal
        {
            get { return puntuacionTotal; }
            set { puntuacionTotal = value; }
        }
        /// <summary>
        /// Atributo Numero de votos + getter/setter
        /// </summary>
        public int NumeroVotos
        {
            get { return numeroVotos; }
            set { numeroVotos = value; }
        }
        /// <summary>
        /// Atributo Codigo postal de usuario + getter/setter
        /// </summary>
        public int CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }
        /// <summary>
        /// Atributo población de usuario + getter/setter
        /// </summary>
        public string Poblacion
        {
            get { return poblacion; }
            set { poblacion = value; }
        }

        /// <summary>
        /// Atributo Eliminado Usuario + getter/setter
        /// </summary>
        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        /// <summary>
        /// Atributo mail de usuario + getter/setter
        /// </summary>
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        /// <summary>
        /// Atributo password de usuario + getter/setter
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Atributo nombr de usuario + getter/setter
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion



    }
}
