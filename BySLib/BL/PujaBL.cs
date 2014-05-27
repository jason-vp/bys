using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.CAD;
using BySLib.EN;
using BySLib.LINQ;

namespace BySLib.BL
{
    public static class PujaBL
    {
        internal static Puja ConvertFromEN(PujaEN prod)
        {
            return new Puja()
            {
                producto = prod.Producto,
                pujador = prod.Propietario,
                valor = prod.Valor,
                fecha = prod.Fecha,
                estado = prod.Estado
                

            };
        }

        private static PujaEN ConvertToEN(Puja prod)//revisar
        {
            return new PujaEN()
            {
                Producto = prod.producto,
                Propietario = prod.pujador,
                Valor = (decimal)prod.valor,
                Fecha = prod.fecha,
                Estado = prod.estado
              

            };
        }
    }
}
