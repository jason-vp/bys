﻿using System;
using System.Collections.Generic;
using BySLib.BL;

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
        private List<FotosProductoEN> fotos = new List<FotosProductoEN>();
        private string estado = "";
        private int cantidadInicial = 0;
        private int cantidadRestante = 0;
        private DateTime fechaFin = new DateTime();
        private List<PujaEN> pujas = new List<PujaEN>();
        private List<CompraEN> compras = new List<CompraEN>();
        private int subcategoria = -1;
        private bool eliminado = false;


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
        public List<FotosProductoEN> Fotos
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

        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        #endregion




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

        //public FotosProductoEN(int id, int idpropietario, string nombre, string descripcion, decimal precioSalida, List<string> fotos, string estado, int cantidadInicial,
        //                    int cantidadRestante, decimal precioCompra, DateTime fechaFin, List<PujaEN> pujas, List<CompraEN> compras, int subcategoria)
        //{

        //    this.id = id;
        //    this.idpropietario = idpropietario;
        //    this.nombre = nombre;
        //    this.descripcion = descripcion;
        //    this.fotos = fotos;
        //    this.estado = estado;
        //    this.precioSalida = precioSalida;
        //    this.precioCompra = precioCompra;
        //    this.cantidadInicial = cantidadInicial;
        //    this.cantidadRestante = cantidadRestante;
        //    this.fechaFin = DateTime.Now;
        //    this.pujas = pujas;
        //    this.compras = compras;
        //    this.subcategoria = subcategoria;

        //}

        public ProductoEN()
        {
            // TODO: Complete member initialization
        }


        

        public bool NoTieneCompras
        {
            get { return this.compras == null || this.compras.Count == 0; }
        }

    }
}
