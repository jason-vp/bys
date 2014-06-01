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


namespace BySLib.EN
{
    /// <summary>
    /// Clase del producto que conecta con la BBDD
    /// </summary>
    public static class ProductoCAD
    {
        /// <summary>
        /// Constante de la conexión a la BBDD
        /// </summary>
        //private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\*.mdf;User Instance=true";

        #region CRUD'S

        /// <summary>
        /// Método para insertar el producto
        /// </summary>
        /// <returns>Devuelve si se ha insertado correctamente</returns>
        public static void Create(BySBDDataContext p_ctx, Producto p_prod)
        {

            p_ctx.Producto.InsertOnSubmit(p_prod);
            p_ctx.SubmitChanges();
        }

        /// <summary>
        /// Método para actualizar el producto
        /// </summary>
        /// <returns>Devuelve si se ha actualizado correctamente</returns>

        public static bool Update(BySBDDataContext p_ctx, Producto p_prod)
        {



            Producto update = (from t1 in p_ctx.Producto
                               where t1.id == p_prod.id
                               select t1).First();

            update.nombre = p_prod.nombre;
            update.descripcion = p_prod.descripcion;
            update.precio_compra = p_prod.precio_compra;
            update.precio_sal = p_prod.precio_sal;
            update.subcat = p_prod.subcat;
            update.estado = p_prod.estado;
            update.fecha_fin = p_prod.fecha_fin;
            update.cant_fin = p_prod.cant_fin;
            update.cant_ini = p_prod.cant_ini;
            update.foto = p_prod.foto;

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
        /// <summary>
        /// Método de borrado en la BBDD de un producto
        /// </summary>
        /// <param name="a">producto a borrar</param>
        /// <returns>true si ha podido borrar el producto</returns>
        public static bool Delete(BySBDDataContext p_ctx, int p_id)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

            //#endregion

            Producto update = (from t1 in p_ctx.Producto
                               where t1.id == p_id
                               select t1).First();

            update.eliminado = true;

            p_ctx.SubmitChanges();

            return true;

        }
        //public static bool Recover(BySBDDataContext p_ctx, long p_id)
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

        #region Getting Data

        public static Producto GetById(BySBDDataContext p_ctx, int p_id)
        {
            return (from t1 in p_ctx.Producto
                    where t1.id == p_id
                    && t1.eliminado == false
                    select t1).SingleOrDefault();

        }

        public static List<Producto> GetByIdPropietario(BySBDDataContext p_ctx, int p_idPro)
        {
            return (from t1 in p_ctx.Producto
                    where t1.usuario == p_idPro
                    && t1.eliminado == false
                    select t1).ToList();

        }

        public static List<Producto> GetByBusqueda(BySBDDataContext p_ctx, string p_bus)
        {
            return (from t1 in p_ctx.Producto
                    where (t1.nombre.Contains(p_bus) 
                    || t1.descripcion.Contains(p_bus)) 
                    && t1.eliminado == false
                    && t1.estado == "Activo"
                    select t1).ToList();

        }

        public static List<Producto> GetBySubcategoria(BySBDDataContext p_ctx, int p_idSub)
        {
            return (from t1 in p_ctx.Producto
                    where t1.subcat == p_idSub
                    && t1.eliminado == false
                    && t1.estado == "Activo"
                    select t1).ToList();

        }

        public static List<Producto> GetByCategoria(BySBDDataContext p_ctx, int p_idCat)
        {
            return (from t1 in p_ctx.Producto
                    join t2 in p_ctx.Subcategoria
                    on t1.subcat equals t2.id
                    where t2.cat_padre == p_idCat
                    && t1.eliminado == false
                    && t1.estado == "Activo"
                    select t1).ToList();

        }

        public static List<Producto> GetByPujadosIdPropietario(BySBDDataContext p_ctx, int p_idPro)
        {
            return (from t1 in p_ctx.Producto
                    join t2 in p_ctx.Puja
                    on t1.usuario equals t2.pujador
                    where t1.usuario == p_idPro
                    && t1.eliminado == false
                    select t1).ToList();

        }

        public static List<Producto> GetByCompradosIdPropietario(BySBDDataContext p_ctx, int p_idPro)
        {
            return (from t1 in p_ctx.Producto
                    join t2 in p_ctx.Compra
                    on t1.usuario equals t2.comprador
                    where t1.usuario == p_idPro
                    && t1.eliminado == false
                    select t1).ToList();

        }

        public static List<Producto> GetByUltimosActivos(BySBDDataContext p_ctx)
        {
            return (from t1 in p_ctx.Producto
                    where t1.eliminado == false
                    && t1.estado == "Activo"
                    orderby t1.id descending
                    select t1).ToList();

        }

        public static List<Producto> GetByDestacados(BySBDDataContext p_ctx)
        {
            return (from t1 in p_ctx.Producto
                    where t1.eliminado == false
                    && t1.estado == "Activo"
                    orderby t1.fecha_fin ascending
                    select t1).Take(12).ToList();

        }

        #endregion

    }
}
