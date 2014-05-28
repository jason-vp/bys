using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;
using BySLib.LINQ;
namespace BySLib.EN
{
    /// <summary>
    /// Esta clase representa la capa de acceso a datos del usuario
    /// </summary>
   public static class SubcategoriaCAD
    {
       



        /// <summary>
        /// Devuelve la subcategoria cuyo id se corresponde con el que se pasa por parametro
        /// </summary>
        /// <param name="id">id de la subcategoria</param>
        /// <returns>subcategoria con el mismo id que el pasado por parametro</returns>
        public static Subcategoria GetById(BySBDDataContext p_ctx, int p_id)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

            //#endregion

            return (from t1 in p_ctx.Subcategoria
                    where t1.id == p_id
                    select t1).SingleOrDefault();

        }

        public static List<Subcategoria> GetByCategoria(BySBDDataContext p_ctx, int p_id)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

            //#endregion

            return (from t1 in p_ctx.Subcategoria
                    where t1.cat_padre == p_id
                    select t1).ToList();

        }

       
       
    }
}
