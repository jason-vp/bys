
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using BySLib.LINQ;


namespace SunAlmondsCore.DALC
{
    public static class ProductoDALC
    {

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

        #region Getting Data

        public static Producto GetById(BySBDDataContext p_ctx, long p_id)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

            //#endregion

            return (from t1 in p_ctx.Producto
                    where t1.id == p_id
                    select t1).SingleOrDefault();
        }

        public static Producto[] GetByIdList(BySBDDataContext p_ctx, List<long> p_lsIds)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_lsIds, 2, MemberInfoGetting.GetMemberName(() => p_lsIds));

            //#endregion

            return (from t1 in p_ctx.Producto
                    where p_lsIds.Contains(t1.id)
                    select t1).ToArray();
        }
        //public static Producto[] GetAll(SunAlmondsCommunicatorDataContext p_ctx)
        //{
        //    //#region Check Parameters

        //    //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //    //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));

        //    //#endregion

        //    return (from t1 in p_ctx.Producto
        //            select t1).ToArray();
        //}
        //public static Producto[] GetAllNotDeleted(SunAlmondsCommunicatorDataContext p_ctx)
        //{
        //    //#region Check Parameters

        //    //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //    //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));

        //    //#endregion

        //    return (from t1 in p_ctx.Producto
        //            where t1.Eliminado == false
        //            select t1).ToArray();
        //}
        //public static Producto GetByProcesoTamanyoProducto(SunAlmondsCommunicatorDataContext p_ctx,
        //    TProceso p_tProc, TTamanyo p_tTam, TProducto p_tProd)
        //{
        //    #region Check Parameters

        //    ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //        p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
        //    ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
        //       Convert.ToInt32(p_tProc), 2, MemberInfoGetting.GetMemberName(() => p_tProc));

        //    #endregion

        //    return (from t1 in p_ctx.Producto
        //            where t1.TProceso == p_tProc && t1.TTamanyo == p_tTam && t1.TProducto == p_tProd
        //            select t1).SingleOrDefault();
        //}
        //public static Producto[] GetAllNotCustomNotDeleted(SunAlmondsCommunicatorDataContext p_ctx)
        //{
        //    #region Check Parameters

        //    ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //        p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));

        //    #endregion

        //    return (from t1 in p_ctx.Producto
        //            where t1.Eliminado == false && t1.TProceso != TProceso.Custom
        //            select t1).ToArray();
        //}
        //public static Producto[] GetAllCustomNotDeleted(SunAlmondsCommunicatorDataContext p_ctx)
        //{
        //    #region Check Parameters

        //    ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //        p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));

        //    #endregion

        //    return (from t1 in p_ctx.Producto
        //            where t1.Eliminado == false && t1.TProceso == TProceso.Custom
        //            select t1).ToArray();
        //}

        #endregion


        #region Public Methods

        //public static bool ExistsById(SunAlmondsCommunicatorDataContext p_ctx, long p_id)
        //{
        //    #region Check Parameters

        //    ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //        p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
        //    ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
        //        p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

        //    #endregion

        //    return p_ctx.Producto.Any(p => p.Id == p_id);
        //}

        #endregion
    }
}
