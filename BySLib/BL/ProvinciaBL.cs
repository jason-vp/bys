using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.LINQ;
using BySLib.EN;

namespace BySLib.BL
{
    public static class ProvinciaBL
    {
        // Devuelve una ProvinciaEN a partir de un id.
        public static ProvinciaEN GetById(string p_dbCnxStr, int p_id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
            {
                return ProvinciaBL.ConvertToEN(ProvinciaCAD.GetById(cnx, p_id));

            }


        }
        //Devuelve una Provincia a partir de un ProvinciaEN.
        internal static Provincia ConvertFromEN(ProvinciaEN prod)
        {
            return new Provincia()
            {
                cod_prov = prod.Cod_provincia,              
                nom_prov = prod.Nombre

            };
        }
        //devuelve un provinciaEN a partir de una Provincia.
        public static ProvinciaEN ConvertToEN(Provincia prod)//revisar
        {
            return new ProvinciaEN()
            {
                Cod_provincia = prod.cod_prov,
                Nombre = prod.nom_prov
                


            };
        }

        



    }
}
