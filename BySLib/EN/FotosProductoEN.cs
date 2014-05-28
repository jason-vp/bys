using System;

namespace BySLib.EN
{
    /// <summary>
    /// Esta clase representa un Producto de la aplicacion (Entidad de negocio)
    /// </summary>
    public class FotosProductoEN : Object, IDisposable
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
        ~FotosProductoEN()
        {
            this.Dispose(false);
        }


        #endregion

        #region Private Properties

        private int id = -1;
        private int idproducto = -1;
        private string ruta = "";




        #endregion

        #region Getters Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        public int Idproducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }

        #endregion
    }
}
