using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.CAD;
using BySLib.EN;
using BySLib.LINQ;


namespace BySLib.BL
{
    public static class ProductoBL
    {
        public static void Create(string dbCnxStr, ProductoEN prod)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbCnxStr))
            {
               // ProductoCAD.Create(cnx, ConvertFromEN(prod));
            }
        }

        private static Producto ConvertFromEN(ProductoEN prod)
        {
            return new Producto()
            {
                id = prod.Id,
                nombre = prod.Nombre,
                descripcion = prod.Descripcion,
                precio_sal = (int)prod.PrecioSalida,
                precio_compra = (int)prod.PrecioCompra,
                estado = prod.Estado,
                cant_ini = prod.CantidadInicial,
                cant_fin = prod.CantidadRestante,
                fecha_fin = prod.FechaFin,
                

            };
        }

     



    }
}
