using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.LINQ;

namespace BySLib.BL
{
    public static class PoblacionBL
    {
        //Obtiene una lista de poblaciones a partir de un codigo postal
        public static List<PoblacionEN> GetByPostalCode(string dbcnx, int id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbcnx))
                return PoblacionBL.ConvertToListPoblacionEn(PoblacionCAD.GetByPostalCode(cnx, id));

        }

        //Devuelve una lista de PoblacionEN a partir de una lista de Poblacion
        public static List<PoblacionEN> ConvertToListPoblacionEn(List<Poblacion> li_pob)
        {
            List<PoblacionEN> ls = new List<PoblacionEN>();

                if (li_pob != null && li_pob.Count > 0)
                    foreach (Poblacion c in li_pob)
                        ls.Add(PoblacionBL.ConvertToEN(c));
            return ls;
        }

        //Devuelve una Poblacion a partir de una PoblacionEN
        internal static Poblacion ConvertFromEN(PoblacionEN prod)
        {
            return new Poblacion()
            {
                cod_prov = prod.Cod_provincia,
                cod_postal = prod.Cod_postal,
                nom_pob = prod.Nombre
  
            };
        }
        //Deielve una PoblacionEn a partir de una Poblacion
        private static PoblacionEN ConvertToEN(Poblacion prod)//revisar
        {
            return new PoblacionEN()
            {
                Cod_provincia = prod.cod_prov,
                Cod_postal = prod.cod_postal,
                Nombre = prod.nom_pob        

            };
        }

    }
}
