using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.LINQ;
using BySLib.EN;

namespace BySLib.BL
{
<<<<<<< HEAD
    public static class CategoriaBL
=======
    public class CategoriaBL
>>>>>>> ea6547dc1163d4af73cfb92df61ea8b39b3ede0a
    {



        #region Getting Data

        public static CategoriaEN GetById(string p_dbCnxStr, int p_id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
            {
                return CategoriaBL.ConvertToCatEN(CategoriaCAD.GetById(cnx, p_id));

            }


        }
        #endregion

        #region Convert To EN

        private static CategoriaEN ConvertToCatEN(Categoria p_sub)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_consume, 1, MemberInfoGetting.GetMemberName(() => p_consume));

            //#endregion

            return new CategoriaEN()
            {
                Id = p_sub.id,
                Nombre = p_sub.nombre

            };

        }

        private static Categoria ConvertFromCatEN(CategoriaEN p_sub)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_consume, 1, MemberInfoGetting.GetMemberName(() => p_consume));

            //#endregion

            return new Categoria()
            {
                id = p_sub.Id,
                nombre = p_sub.Nombre

            };

        }


        #endregion

    }
}
