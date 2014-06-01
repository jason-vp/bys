using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.LINQ;
using BySLib.EN;

namespace BySLib.BL
{

    public static class SubcategoriaBL{


        #region Getting Data

        public static SubcategoriaEN GetById(string p_dbCnxStr, int p_id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
            {
                return SubcategoriaBL.ConvertToSubEN(SubcategoriaCAD.GetById(cnx, p_id));

            }


        }
        public static List<SubcategoriaEN> GetAll(string p_dbCnxStr)
        {

            List<SubcategoriaEN> ls = new List<SubcategoriaEN>();
            List<Subcategoria> lsProdu = new List<Subcategoria>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = SubcategoriaCAD.GetAll(cnx);

            foreach (Subcategoria c in lsProdu)
                ls.Add(SubcategoriaBL.ConvertToSubEN(c));
            return ls;



        }


        #endregion

        #region Convert To EN

        private static SubcategoriaEN ConvertToSubEN(Subcategoria p_sub)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_consume, 1, MemberInfoGetting.GetMemberName(() => p_consume));

            //#endregion

            return new SubcategoriaEN()
            {
                Id = p_sub.id,
                Nombre = p_sub.nombre,
                Padre = p_sub.cat_padre
                
                
            };

        }

        private static Subcategoria ConvertFromSubEN(SubcategoriaEN p_sub)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_consume, 1, MemberInfoGetting.GetMemberName(() => p_consume));

            //#endregion

            return new Subcategoria()
            {
                id = p_sub.Id,
                nombre = p_sub.Nombre,
                cat_padre = p_sub.Padre
                
            };

        }


        #endregion



    }
}
