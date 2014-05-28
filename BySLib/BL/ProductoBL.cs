using System.Collections.Generic;
using System.Data.Linq;
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
                ProductoCAD.Create(cnx, ConvertFromEN(prod));
            }
        }

        #region Convert To DTO

        private static List<FotosProductoEN> ConvertToListFotosEn(EntitySet<FotosProducto> p_lsFotos)
        {
            if (p_lsFotos == null || p_lsFotos.Count <= 0)
                return new List<FotosProductoEN>();

            List<FotosProductoEN> ls = new List<FotosProductoEN>();
            foreach (FotosProducto c in p_lsFotos)
                ls.Add(ConvertToFotosEN(c));

            return ls;
        }
        private static EntitySet<FotosProducto> ConvertToEntitytFotosEn(List<FotosProductoEN> p_lsFotos)
        {
            if (p_lsFotos == null || p_lsFotos.Count <= 0)
                return new EntitySet<FotosProducto>();

            EntitySet<FotosProducto> ls = new EntitySet<FotosProducto>();
            foreach (FotosProductoEN c in p_lsFotos)
                ls.Add(ConvertFromFotosEN(c));

            return ls;
        }



        private static FotosProductoEN ConvertToFotosEN(FotosProducto p_fotos)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_consume, 1, MemberInfoGetting.GetMemberName(() => p_consume));

            //#endregion

            return new FotosProductoEN()
            {
                Id = p_fotos.id,
                Ruta = p_fotos.ruta,
                Idproducto = (int)p_fotos.producto//revisar
            };

        }

        private static FotosProducto ConvertFromFotosEN(FotosProductoEN p_fotos)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_consume, 1, MemberInfoGetting.GetMemberName(() => p_consume));

            //#endregion

            return new FotosProducto()
            {
                id = p_fotos.Id,
                ruta = p_fotos.Ruta,
                producto = (int)p_fotos.Idproducto//revisar
            };

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
                FotosProducto = ConvertToEntitytFotosEn(prod.Fotos),
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
                Fotos = ConvertToListFotosEn(prod.FotosProducto),
                Eliminado = (bool)prod.eliminado

            };
        }

     
        #endregion


    }
}
