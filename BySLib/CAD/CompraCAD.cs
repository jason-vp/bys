using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Text;
using BySLib.EN;
using BySLib.LINQ;

namespace BySLib
{
    /// <summary>
    /// Esta clase representa la capa de acceso a datos de compras
    /// </summary>
    public static class CompraCAD
    {


        #region CRUD'S

        public static void Create(BySBDDataContext p_ctx, Compra p_com)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_cli, 2, MemberInfoGetting.GetMemberName(() => p_cli));

            //#endregion

            p_ctx.Compra.InsertOnSubmit(p_com);
            p_ctx.SubmitChanges();


        }
        public static bool Update(BySBDDataContext p_ctx, Compra p_com)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_cli, 2, MemberInfoGetting.GetMemberName(() => p_cli));

            //#endregion

            Compra update = (from t1 in p_ctx.Compra
                              where t1.producto == p_com.producto
                              && t1.comprador == p_com.comprador
                              select t1).First();

            update.producto = p_com.producto;
            update.comprador = p_com.comprador;
            update.comentario = p_com.comentario;
            update.puntuacion = p_com.puntuacion;
            update.fecha = p_com.fecha;
            


            p_ctx.SubmitChanges();

            return true;
        }

        //public static bool UpdateEnabled(BySBDDataContext p_ctx, int p_id)
        //{

        //    Usuario update = (from t1 in p_ctx.Usuario
        //                      where t1.id == p_id
        //                      select t1).First();



        //    p_ctx.SubmitChanges();

        //    return true;
        //}

        /// <summary>
        /// Borra el usuario actual de la DB
        /// </summary>
        /// <returns>True si se borró</returns>
        public static bool Delete(BySBDDataContext p_ctx, Compra p_com)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

            //#endregion

            Compra update = (from t1 in p_ctx.Compra
                             where t1.producto == p_com.producto
                             && t1.comprador == p_com.comprador
                              select t1).First();

            update.eliminado = true;

            p_ctx.SubmitChanges();

            return true;
        }

        #endregion
        #region Getting Data


        public static List<Compra> GetByIdPropietario(BySBDDataContext p_ctx, int p_id)
        {
            return (from t1 in p_ctx.Compra
                    where t1.comprador == p_id
                    && t1.eliminado == false
                    select t1).ToList();

        }


        #endregion


    }
}
