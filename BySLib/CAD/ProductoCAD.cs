using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using BySLib.EN;
using System.Data.SqlClient;
using System.Data;
using BySLib.Utilities;
using BySLib.LINQ;


namespace BySLib.CAD
{
	/// <summary>
	/// Clase del producto que conecta con la BBDD
	/// </summary>
	public static class ProductoCAD
	{
		/// <summary>
		/// Constante de la conexión a la BBDD
		/// </summary>
		private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\*.mdf;User Instance=true";

        #region CRUD'S

        public static void Create(BySBDDataContext p_ctx, Producto p_prod)
        {


            p_ctx.Producto.InsertOnSubmit(p_prod);
            p_ctx.SubmitChanges();
        }
        public static bool Update(BySBDDataContext p_ctx, Producto p_prod)
        {



            Producto update = (from t1 in p_ctx.Producto
                               where t1.id == p_prod.id
                               select t1).First();

            update.nombre = p_prod.nombre;
            update.descripcion = p_prod.descripcion;
            update.precio_compra = p_prod.precio_compra;
            update.precio_sal = p_prod.precio_sal;
            /*update. = p_prod.CustomName;
            update.CustomPrecioEuro = p_prod.CustomPrecioEuro;
            update.CustomPrecioDolar = p_prod.CustomPrecioDolar;
            */
            p_ctx.SubmitChanges();

            return true;

        }
        //public static bool UpdateEnabled(BySBDDataContext p_ctx, long p_id, bool p_habilitado)
        //{
        //    #region Check Parameters

        //    ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //        p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
        //    ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
        //        p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));
        //    ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //        p_habilitado, 3, MemberInfoGetting.GetMemberName(() => p_habilitado));

        //    #endregion

        //    Producto update = (from t1 in p_ctx.Producto
        //                       where t1.Id == p_id
        //                       select t1).First();

        //    update.Habilitado = p_habilitado;

        //    p_ctx.SubmitChanges();

        //    return true;
        //}
        //public static bool Delete(SunAlmondsCommunicatorDataContext p_ctx, long p_id)
        //{
        //    #region Check Parameters

        //    ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //        p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
        //    ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
        //        p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

        //    #endregion

        //    Producto update = (from t1 in p_ctx.Producto
        //                       where t1.Id == p_id
        //                       select t1).First();

        //    update.Eliminado = true;

        //    p_ctx.SubmitChanges();

        //    return true;

        //}
        //public static bool Recover(SunAlmondsCommunicatorDataContext p_ctx, long p_id)
        //{
        //    #region Check Parameters

        //    ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //        p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
        //    ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
        //        p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

        //    #endregion

        //    Producto update = (from t1 in p_ctx.Producto
        //                       where t1.Id == p_id
        //                       select t1).First();

        //    update.Eliminado = false;

        //    p_ctx.SubmitChanges();

        //    return true;
        //}

        #endregion

		/// <summary>
		/// Obtenemos todos los producto  en un array
		/// </summary>
		/// <returns>Lista de todos los producto</returns>
		static public ProductoEN[] obtenerTodosProductos()
		{
            ProductoEN[] productos = null;
			return productos;
		}

		/// <summary>
		/// Obtenemos el artículo por el id
		/// </summary>
		/// <param name="id">Id del producto a obtener</param>
		/// <returns>producto por el id</returns>
		static public ProductoEN obtenerProductoById(int id)
		{
            ProductoEN producto = null;

			return producto;
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

        internal static bool Create(ProductoEN prod)
        {
            throw new NotImplementedException();
        }
    }
}
