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

namespace BySLib.EN
{
    /// <summary>
    /// Clase de la puja que conecta con la BBDD
    /// </summary>
   public static class PujaCAD
    {
        #region CRUD'S

        public static void Create(BySBDDataContext p_ctx, Puja p_puj)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_cli, 2, MemberInfoGetting.GetMemberName(() => p_cli));

            //#endregion

            p_ctx.Puja.InsertOnSubmit(p_puj);
            p_ctx.SubmitChanges();


        }
        public static bool Update(BySBDDataContext p_ctx, Puja p_puj)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_cli, 2, MemberInfoGetting.GetMemberName(() => p_cli));

            //#endregion

            Puja update = (from t1 in p_ctx.Puja
                             where t1.producto == p_puj.producto
                             && t1.pujador == p_puj.pujador
                             select t1).First();

            update.producto = p_puj.producto;
            update.pujador = p_puj.pujador;
            update.valor = p_puj.valor;
            update.estado = p_puj.estado;
            update.fecha = p_puj.fecha;



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

        ///// <summary>
        ///// Borra el usuario actual de la DB
        ///// </summary>
        ///// <returns>True si se borró</returns>
        //public static bool Delete(BySBDDataContext p_ctx, Puja p_puj)
        //{
        //    //#region Check Parameters

        //    //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
        //    //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
        //    //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
        //    //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

        //    //#endregion

        //    Puja update = (from t1 in p_ctx.Puja
        //                     where t1.producto == p_puj.producto
        //                     && t1.pujador == p_puj.pujador
        //                     select t1).First();

        //    update.eliminado = true;

        //    p_ctx.SubmitChanges();

        //    return true;
        //}

        #endregion

        #region Getting Data
        public static Puja GetByIdProducto(BySBDDataContext p_ctx, int p_id)
        {
            return (from t1 in p_ctx.Puja
                    where t1.producto == p_id                 
                    select t1).SingleOrDefault();

        }



        #endregion


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
