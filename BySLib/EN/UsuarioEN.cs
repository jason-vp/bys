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
        /// 
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }
        public int Telf
        {
            get { return telf; }
            set { telf = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public decimal Credito
        {
            get { return credito; }
            set { credito = value; }
        }
        public decimal Puntacion
        {
            get { return puntacion; }
            set { puntacion = value; }
        }
        public int PuntuacionTotal
        {
            get { return puntuacionTotal; }
            set { puntuacionTotal = value; }
        }
        public int NumeroVotos
        {
            get { return numeroVotos; }
            set { numeroVotos = value; }
        }
        public int CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }
        public string Poblacion
        {
            get { return poblacion; }
            set { poblacion = value; }
        }
        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion



    }
}
