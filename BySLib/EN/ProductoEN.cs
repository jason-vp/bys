using System;
using BySLib.Utilities;
using BySLib.EN;
using BySLib.CAD;
using System.Collections.Generic;

namespace BySLib.EN
{

    /// <summary>
    /// Esta clase representa un Producto de la aplicacion (Entidad de negocio)
    /// </summary>
    public class ProductoEN : Object, IDisposable
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
        ~ProductoEN()
        {
            this.Dispose(false);
        }

        #endregion

        #region Private Properties

        private int id = -1;
        private int idpropietario = -1;
        private string nombre = "";
        private string descripcion = "";
        private decimal precioSalida = 0;
        private decimal precioCompra = 0;
        private List<string> fotos = new List<string>();
        private string estado = "";
        private int cantidadInicial = 0;
        private int cantidadRestante = 0;
        private DateTime fechaFin = new DateTime();
        private List<PujaEN> pujas = new List<PujaEN>();
        private List<CompraEN> compras = new List<CompraEN>();
        private int subcategoria;
        #endregion

        #region Public Properties
        /// <summary>
        /// Propiedad del id del producto
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Propiedad del propietario del producto
        /// </summary>
        public int Propietario
        {
            get { return idpropietario; }
            set { idpropietario = value; }
        }
        /// <summary>
        /// Propiedad de la fecha del producto
        /// </summary>
        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        /// <summary>
        /// Propiedad del nombre del producto
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Propiedad de la descripcion del producto
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        /// <summary>
        /// Propiedad del precio de salida del producto
        /// </summary>
        public decimal PrecioSalida
        {
            get { return precioSalida; }
            set { precioSalida = value; }
        }
        /// <summary>
        /// Propiedad del precio de compra del producto
        /// </summary>
        public decimal PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }
        /// <summary>
        /// Propiedad del estado del producto
        /// </summary>
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        /// <summary>
        /// Propiedad de la cantidad inicial del producto
        /// </summary>
        public int CantidadInicial
        {
            get { return cantidadInicial; }
            set { cantidadInicial = value; }
        }
        /// <summary>
        /// Propiedad de la cantidad restante del producto
        /// </summary>
        public int CantidadRestante
        {
            get { return cantidadRestante; }
            set { cantidadRestante = value; }
        }

        /// <summary>
        /// Propiedad de las pujas del producto
        /// </summary>
        public List<PujaEN> Pujas
        {
            get { return pujas; }
            set { pujas = value; }
        }
        /// <summary>
        /// Propiedad de las compras del producto
        /// </summary>
        public List<CompraEN> Compras
        {
            get { return compras; }
            set { compras = value; }
        }
        /// <summary>
        /// Propiedad de las fotos del producto
        /// </summary>
        public List<string> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }
        /// <summary>
        /// Propiedad de la subcategoria del producto
        /// </summary>
        public int Subcategoria
        {
            get { return subcategoria; }
            set { subcategoria = value; }
        }



        #endregion


        /// <summary>
        /// Obtiene todos los productos de la DB
        /// </summary>
        /// <returns>Devuelve un array de producto con todos los productos leidos de la DB</returns>
        static public ProductoEN[] getProducto()
        {
            // Lee los productos de la DB y los devuelve
            return ProductoCAD.obtenerTodosProductos();
        }

        /// <summary>
        /// Obtiene un producto a traves de su id
        /// </summary>
        /// <param name="id">El producto del usuario que se devolvera</param>
        /// <returns>Devuelve un Producto cuyo id se pasó por parámetro</returns>
        static public ProductoEN getProducto(int id)
        {
            // busca el producto por el id en la DB
            return ProductoCAD.obtenerProductoById(id);
        }

        /// <summary>
        /// Comprueba si un producto existe en la DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve verdadero si el producto existe en la BD</returns>
        public static bool esProducto(int id)
        {
            return ProductoCAD.esProducto(id);
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="id">El id del producto</param>
        /// <param name="idpropietario">El usuario propietario del del producto</param>
        /// <param name="nombre">El nombre del producto</param>
        /// <param name="fotos">La ruta de las fotos</param>
        /// <param name="precioSalida">El precio de salida del producto</param>
        /// <param name="precioSalida">El precio de salida del producto</param>
        /// <param name="precioCompra">El precio de compra del producto</param>
        /// <param name="fechaFin">La fecha de fin de la subasta del producto</param>
        /// <param name="estado">El estado en el que se encuentra el producto</param>
        /// <param name="cantidadInicial">La cantidad inicial de productos</param>
        /// <param name="cantidadRestante">La cantidad de productos restantes</param>
        /// <param name="pujas">Las pujas asociadas al producto</param>
        /// <param name="compras">La fecha de fin de la subasta del producto</param>
        /// <param name="subcategoria">La subcategoria del producto</param>

        public ProductoEN(int id, int idpropietario, string nombre, string descripcion, decimal precioSalida, List<string> fotos, string estado, int cantidadInicial,
                            int cantidadRestante, decimal precioCompra, DateTime fechaFin, List<PujaEN> pujas, List<CompraEN> compras, int subcategoria)
        {

            this.id = id;
            this.idpropietario = idpropietario;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fotos = fotos;
            this.estado = estado;
            this.precioSalida = precioSalida;
            this.precioCompra = precioCompra;
            this.cantidadInicial = cantidadInicial;
            this.cantidadRestante = cantidadRestante;
            this.fechaFin = DateTime.Now;
            this.pujas = pujas;
            this.compras = compras;
            this.subcategoria = subcategoria;

        }

        /// <summary>
        /// Confirma los cambios del Producto en la DB. Inserta o modifica.
        /// </summary>
        /// <returns>Devuelve true si se llevó a cabo la insercion/acatualizacion o false en caso contrario</returns>
        public bool commitDB()
        {
            // Inserta en la DB si no existe y lo actualiza si ya existía
            // ProductoCAD cad = new ProductoCAD(this);
            return false;// cad.insertarActualizar();
        }

        /// <summary>
        /// Borra el Producto actual de la DB
        /// </summary>
        /// <returns>Devuelve true si se borró con éxito o false en caso contrario</returns>
        public bool borrarDB()
        {
            // Borra el Producto actual de la DB
            // ProductoCAD cad = new ProductoCAD(this);
            return false;// cad.borrar();
        }

        public bool NoTieneCompras
        {
            get { return this.compras == null || this.compras.Count == 0; }
        }

    }
}
