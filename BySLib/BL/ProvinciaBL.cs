using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.LINQ;
using BySLib.EN;

namespace BySLib.BL
{
    class ProvinciaBL
    {


        internal static Provincia ConvertFromEN(ProvinciaEN prod)
        {
            return new Provincia()
            {
                cod_prov = prod.Cod_provincia,              
                nom_prov = prod.Nombre

            };
        }

        private static ProvinciaEN ConvertToEN(Provincia prod)//revisar
        {
            return new ProvinciaEN()
            {
                Cod_provincia = prod.cod_prov,
                Nombre = prod.nom_prov
                


            };
        }



    }
}
