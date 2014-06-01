using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.LINQ;
using BySLib.EN;
using System.Data.Linq;

namespace BySLib.BL
{

    public static class CategoriaBL
    {
        #region Getting Data

        //Obiene una categoria a partir de su ID
        public static CategoriaEN GetById(string p_dbCnxStr, int p_id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
            {
                return CategoriaBL.ConvertToCatEN(CategoriaCAD.GetById(cnx, p_id));

            }


        }

        //Obtiene una lista de todas las categorias
        public static List<CategoriaEN> GetAll(string p_dbCnxStr)
        {

            List<CategoriaEN> ls = new List<CategoriaEN>();
            List<Categoria> lsProdu = new List<Categoria>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = CategoriaCAD.GetAll(cnx);

            foreach (Categoria c in lsProdu)
                ls.Add(CategoriaBL.ConvertToCatEN(c));
            return ls;


        }

        #endregion

        #region Convert To EN
        //Devuelve la lista de las subcategorias de una clase padre que se pasa por parametro.
        private static List<SubcategoriaEN> ConvertToListSubcategoriaEn(EntitySet<Subcategoria> p_sub)
        {
            if (p_sub == null || p_sub.Count <= 0) //TODO: aqui falla algo
                return new List<SubcategoriaEN>();

            List<SubcategoriaEN> ls = new List<SubcategoriaEN>();
            foreach (Subcategoria c in p_sub)
                ls.Add(ConvertToSubEN(c));

            return ls;
        }
        //Convierte una EntitySet en una Subcategoria.
        private static EntitySet<Subcategoria> ConvertToEntitytSubcategoriaEn(List<SubcategoriaEN> p_sub)
        {
            if (p_sub == null || p_sub.Count <= 0)
                return new EntitySet<Subcategoria>();

            EntitySet<Subcategoria> ls = new EntitySet<Subcategoria>();
            foreach (SubcategoriaEN c in p_sub)
                ls.Add(ConvertFromSubEN(c));

            return ls;
        }
        //Convierte un conjunto de datos en una subcategoria y la devuelve.
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
        //Convierte de una EN en una Subcategoria.
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
        //
        private static CategoriaEN ConvertToCatEN(Categoria p_sub)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_consume, 1, MemberInfoGetting.GetMemberName(() => p_consume));

            //#endregion

            return new CategoriaEN()
            {
                Id = p_sub.id,
                Nombre = p_sub.nombre,
                Subcateg = ConvertToListSubcategoriaEn(p_sub.Subcategoria)
                
                

            };

        }
        //Convierte una CategoriaEN en una Categoria.
        private static Categoria ConvertFromCatEN(CategoriaEN p_sub)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_consume, 1, MemberInfoGetting.GetMemberName(() => p_consume));

            //#endregion

            return new Categoria()
            {
                id = p_sub.Id,
                nombre = p_sub.Nombre,
                Subcategoria = ConvertToEntitytSubcategoriaEn(p_sub.Subcateg)

            };

        }


        #endregion

    }
}
