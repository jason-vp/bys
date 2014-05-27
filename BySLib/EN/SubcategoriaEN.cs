using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib;

namespace BySLib.EN
{


    /// <summary>
    /// Esta clase representa un Usuario de la aplicacion (Entidad de negocio)
    /// </summary>
    public class SubcategoriaEN : Object, IDisposable
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
        ~SubcategoriaEN()
        {
            this.Dispose(false);
        }

        #endregion

        #region Private Properties
        private int id = -1;
        private string nombre = "";
        private int padre = -1;

        #endregion

        #region Getters Setters

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Padre
        {
            get { return padre; }
            set { padre = value; }
        }
        #endregion




      

 
    }
}
