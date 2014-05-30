using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BySLib;

namespace BySLib.EN
{
    /// <summary>
    /// Esta clase representa un Usuario de la aplicacion (Entidad de negocio)
    /// </summary>
    public class CategoriaEN : Object, IDisposable
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
        ~CategoriaEN()
        {
            this.Dispose(false);
        }

        #endregion
        #region Private Properties
        private int id = -1;
        private string nombre = "";
        #endregion
        #region public Properties
        /// <summary>
        /// Identificador de la categoria + getter/setter
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Nombre categoria + getter/setter
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        #endregion



        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="id">id de la categoria</param>
        /// <param name="nombre">nombre de la categoria</param>
        public CategoriaEN(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public CategoriaEN()
        {
            // TODO: Complete member initialization
        }



    }
}
