using System;

namespace BySLib.EN
{
    /// <summary>
    /// Esta clase representa un Producto de la aplicacion (Entidad de negocio)
    /// </summary>
    public class PujaEN: Object , IDisposable
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
        ~PujaEN()
        {
            this.Dispose(false);
        }

        #endregion
        #region Private Properties

        private int pujador =-1;
        private int producto = -1;
        private decimal valor = 0;
        private string estado = "Mejor";
        private DateTime fecha = new DateTime();
        #endregion

        #region Public Properties

        /// <summary>
        /// Propiedad del pujador
        /// </summary>
        public int Propietario
        {
            get { return pujador; }
            set { pujador = value; }
        }

        /// <summary>
        /// Propiedad del producto
        /// </summary>
        public int Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        /// <summary>
        /// Propiedad de la fecha de la puja
        /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        /// <summary>
        /// Propiedad del valor de la puja
        /// <summary>
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Atributo estado de la puja + getter/setter
        /// </summary>
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion

        
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
		/// <param name="pujador">El usuario pujador del del producto</param>
        /// <param name="producto">El producto</param>
		/// <param name="estado">El estado en el que se encuentra la puja</param>
        /// <param name="valor">El valor de la puja</param>

        public PujaEN(int pujador, int producto, string estado, decimal valor)
        {

			this.pujador = pujador;
            this.producto = producto;
			this.estado = estado;
            this.fecha = DateTime.Now;
            this.estado = estado;
			this.valor = valor;
            
        }

        public PujaEN()
        {
            // TODO: Complete member initialization
        }

       

    }
}
