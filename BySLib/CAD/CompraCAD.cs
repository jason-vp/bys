using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;

namespace BySLib
{
    /// <summary>
    /// Esta clase representa la capa de acceso a datos de compras
    /// </summary>
    class CompraCAD
    {
        /// <summary>
        /// Constante que indica los parametros de conexion de la BD
        /// </summary>
        private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Videoclub.mdf;User Instance=true";

        /// <summary>
        /// Representa la entidad de negocio relacionada con el CAD
        /// </summary>
        private CompraEN compra;

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="compra">Es la entidad de negocio relacionada con esta compra</param>
        public CompraCAD(CompraEN compra)
        {
            this.compra = compra;
        }

        /// <summary>
        /// Funcion para Insertar las compras
        /// </summary>
        public void Insertar()
        { }

        /// <summary>
        /// Funcion para Actualizar las compras
        /// </summary>
        public void Actualizar()
        { }

        /// <summary>
        /// Funcion para Borrar las compras
        /// </summary>
        public void Borrar()
        { }

        /// <summary>
        /// Funcion para Borrar las compras
        /// </summary>
        public CompraEN ObtenerPorId()
        { }

        /// <summary>
        /// Funcion Listar las Compras
        /// </summary>
        public CompraEN[] listarCompra() 
        { }       

    }
}
