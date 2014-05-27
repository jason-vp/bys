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

        internal static Producto ConvertFromEN(ProductoEN prod)
        {
            return new Producto()
            {
                id = prod.Id,
                nombre = prod.Nombre,
                descripcion = prod.Descripcion,
                precio_sal = prod.PrecioSalida,
                precio_compra = prod.PrecioCompra,
                estado = prod.Estado,
                cant_ini = prod.CantidadInicial,
                cant_fin = prod.CantidadRestante,
                fecha_fin = prod.FechaFin,
                usuario = prod.Propietario,
                subcat = prod.Subcategoria,
                eliminado = prod.Eliminado

            };
        }

        private static ProductoEN ConvertToEN(Producto prod)//revisar
        {
            return new ProductoEN()
            {
                Id = prod.id,
                Nombre = prod.nombre,
                Descripcion = prod.descripcion,
                PrecioSalida = (decimal)prod.precio_sal,
                PrecioCompra = (decimal)prod.precio_compra,
                Estado = prod.estado,
                CantidadInicial = (int)prod.cant_ini,
                CantidadRestante = (int)prod.cant_fin,
                FechaFin = prod.fecha_fin,
                Propietario = prod.usuario,
                Subcategoria = (int)prod.subcat,
                Eliminado = (bool)prod.eliminado

            };
        }

     



    }
}
