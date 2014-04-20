using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;
using System.Data.SqlClient;
using System.Data;
using BySLib.Utilities;


namespace BySLib.CAD
{
	/// <summary>
	/// Clase del producto que conecta con la BBDD
	/// </summary>
	public class ProductoCAD
	{
		/// <summary>
		/// Constante de la conexión a la BBDD
		/// </summary>
		private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\*.mdf;User Instance=true";
		

		/// <summary>
		/// Obtenemos todos los producto  en un array
		/// </summary>
		/// <returns>Lista de todos los producto</returns>
		static public ProductoEN[] obtenerTodosProductos()
		{
		
			return ;
		}

		/// <summary>
		/// Obtenemos el artículo por el id
		/// </summary>
		/// <param name="id">Id del producto a obtener</param>
		/// <returns>producto por el id</returns>
		static public ProductoEN obtenerProductoById(int id)
		{
			
			return ;
		}

		/// <summary>
		/// Obtenemos true si el producto existe
		/// </summary>
		/// <param name="id">id del producto a obtener</param>
		/// <returns>verdadero si el producto existe, falso en caso contrario</returns>
		static public bool esProducto(int id)
		{
		
			return false;
		}

		/// <summary>
		/// Método para insertar el producto
		/// </summary>
		/// <returns>Devuelve si se ha insertado correctamente</returns>
		private bool insertar()
		{
			
			return false;
		}
		
		/// <summary>
		/// Método para actualizar el producto
		/// </summary>
		/// <returns>Devuelve si se ha actualizado correctamente</returns>
		private bool actualizar()
		{
			
			return false;
		}

		

		/// <summary>
		/// Método de borrado en la BBDD de un producto
		/// </summary>
		/// <param name="a">producto a borrar</param>
		/// <returns>true si ha podido borrar el producto</returns>
		public bool borrar(int estado)
		{
			
			return false;
		}
	}
}
