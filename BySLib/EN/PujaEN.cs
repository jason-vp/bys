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
        /// Obtiene todos las pujas de la DB
        /// </summary>
        /// <returns>Devuelve un array de producto con todos los productos leidos de la DB</returns>
        static public PujaEN[] getPujas()
        {
            // Lee los productos de la DB y los devuelve
            return null;// PujaCAD.obtenerTodasPujas();
        }

        /// <summary>
        /// Obtiene una puja a traves de su id
        /// </summary>
        /// <param name="idProducto">El id del producto de la puja</param>
        /// <param name="idPujador">El id del usuario de la puja</param>
        /// <returns>Devuelve un Producto cuyo id se pasó por parámetro</returns>
        static public PujaEN getPuja(int idProducto, int idPujador)
        {
            // busca la puja por los id en la DB
            return null;// PujaCAD.obtenerPujaById(idProducto, idPujador);
        }

        /// <summary>
        /// Comprueba si un puja existe en la DB
        /// </summary>
         /// <param name="idProducto">El id del producto de la puja</param>
        /// <param name="idPujador">El id del usuario de la puja</param>
        /// <returns>Devuelve verdadero si la puja existe en la BD</returns>
        public static bool esPuja(int idProducto, int idPujador)
        {
            return false;// PujaCAD.esPuja(id);
        }

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

        /// <summary>
        /// Confirma los cambios de la puja en la DB. Inserta o modifica.
        /// </summary>
        /// <returns>Devuelve true si se llevó a cabo la insercion/acatualizacion o false en caso contrario</returns>
        public bool commitDB()
        {
            // Inserta en la DB si no existe y lo actualiza si ya existía
           // PujaCAD cad = new PujaCAD(this);
            return false;// cad.insertarActualizar();
        }

        /// <summary>
        /// Borra la puja actual de la DB
        /// </summary>
        /// <returns>Devuelve true si se borró con éxito o false en caso contrario</returns>
        public bool borrarDB()
        {
            // Borra el Producto actual de la DB
            //PujaCAD cad = new PujaCAD(this);
            return false;//cad.borrar();
        }

    }
}
