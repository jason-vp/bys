using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;
using BySLib.CAD;

namespace BySLib.CAD
{
    /// <summary>
    /// Clase de la puja que conecta con la BBDD
    /// </summary>
   public static class PujaCAD
    {
        ///// <summary>
        ///// Constante de la conexión a la BBDD
        ///// </summary>
        //private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\*.mdf;User Instance=true";


      
        
        /// <summary>
        /// Obtenemos todos los producto  en un array
        /// </summary>
        /// <returns>Lista de todos los producto</returns>
        static public PujaEN[] obtenerTodasPujas()
        {
            List<PujaEN> puja = new List<PujaEN>();

            return puja.ToArray();
        }

        /// <summary>
        /// Obtenemos la puja por el id
        /// </summary>
        /// <param name="idProducto">Id del producto de la puja</param>
        /// <param name="idPujador">Id del producto de la puja</param>
        /// <returns>producto por el id</returns>
        static public PujaEN obtenerPujaById(int idProducto, int idPujador)
        {
            PujaEN producto = null;

            return producto;
        }

        /// <summary>
        /// Obtenemos true si la puja existe
        /// </summary>
        /// <param name="idProducto">Id del producto de la puja</param>
        /// <param name="idPujador">Id del producto de la puja</param>
        /// <returns>verdadero si la puja existe, falso en caso contrario</returns>
        static public bool esPuja(int idProducto, int idPujador)
        {

            return false;
        }

       
    }
}
