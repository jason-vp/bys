using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib;


namespace BySLib.EN
{
    /// <summary>
    /// Esta clase representa un Compra de la aplicacion (Entidad de Negocio)
    /// </summary>
    public class CompraEN : Object, IDisposable
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
        ~CompraEN()
        {
            this.Dispose(false);
        }

        #endregion
        #region Private Properties
        private int pujador = -1;
        private int producto = -1;
        private DateTime fecha;//revisar
        private string comentario = "";
        private int puntuacion = 0;

        #endregion

        #region Getter y Setters

        /// <summary>
        /// Atributo pujador de compra + getter/setter
        /// </summary>
        public int Pujador
        {
            get { return pujador; }
            set { pujador = value; }
        }

        /// <summary>
        /// Atributo producto + getter/setter
        /// </summary>
        public int Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        /// <summary>
        /// Atributo fecha + getter/setter
        /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        /// <summary>
        /// Atributo comentario + getter/setter
        /// </summary>
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        /// <summary>
        /// Atributo Puntuación + getter/setter
        /// </summary>
        public int Puntuacion
        {
            get { return puntuacion; }
            set { puntuacion = value; }
        }
        #endregion


        //public CompraEN(int pujador, int producto, DateTime fecha, string comentario, int puntuacion)
        //{
        //    this.pujador = pujador;
        //    this.producto = producto;
        //    this.fecha = fecha;
        //    this.comentario = comentario;
        //    this.puntuacion = puntuacion;
        //}

        //public void Insertar(CompraEN compra_nueva)
        //{ }

        //public void Borrar(CompraEN compra)
        //{ }

        //public void Actualizar(CompraEN compra)
        //{ }



    }
}
