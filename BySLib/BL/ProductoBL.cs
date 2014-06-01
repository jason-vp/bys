using System.Collections.Generic;
using System.Data.Linq;
using BySLib.EN;
using BySLib.LINQ;


namespace BySLib.BL
{

    #region CRUD'S
    public static class ProductoBL
    {
        public static void Create(string dbCnxStr, ProductoEN prod)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbCnxStr))
            {
                ProductoCAD.Create(cnx, ConvertFromEN(prod));
            }
        }
        public static bool UpdateFromEN(string p_dbCnxStr, ProductoEN p_com)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return ProductoCAD.Update(cnx, ProductoBL.ConvertFromEN(p_com));

        }

        public static bool Delete(string p_dbCnxStr, int p_id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return ProductoCAD.Delete(cnx, p_id);

        }



    #endregion
        #region Getting Data

        public static ProductoEN GetByIdToEN(string p_dbCnxStr, int p_id)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return ProductoBL.ConvertToEN(ProductoCAD.GetById(cnx, p_id));

        }

        public static List<ProductoEN> GetByBusquedaEN(string p_dbCnxStr, string p_bus)
        {

            List<ProductoEN> ls = new List<ProductoEN>();
            List<Producto> lsProdu = new List<Producto>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = ProductoCAD.GetByBusqueda(cnx, p_bus);

            foreach (Producto c in lsProdu)
                ls.Add(ProductoBL.ConvertToEN(c));
            return ls;
        }

        public static List<ProductoEN> GetBySubcategoriaEN(string p_dbCnxStr, int p_id)
        {

            List<ProductoEN> ls = new List<ProductoEN>();
            List<Producto> lsProdu = new List<Producto>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = ProductoCAD.GetBySubcategoria(cnx,p_id);

            foreach (Producto c in lsProdu)
                ls.Add(ProductoBL.ConvertToEN(c));
            return ls;
        }

        public static List<ProductoEN> GetByCategoriaEN(string p_dbCnxStr, int p_id)
        {

            List<ProductoEN> ls = new List<ProductoEN>();
            List<Producto> lsProdu = new List<Producto>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = ProductoCAD.GetByCategoria(cnx, p_id);

            foreach (Producto c in lsProdu)
                ls.Add(ProductoBL.ConvertToEN(c));
            return ls;
        }

        public static List<ProductoEN> GetByIdPropietarioEN(string p_dbCnxStr, int p_id)
        {

            List<ProductoEN> ls = new List<ProductoEN>();
            List<Producto> lsProdu = new List<Producto>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = ProductoCAD.GetByIdPropietario(cnx,p_id);

            foreach (Producto c in lsProdu)
                ls.Add(ProductoBL.ConvertToEN(c));
            return ls;
        }

        public static List<ProductoEN> GetByPujadosIdPropietarioEN(string p_dbCnxStr, int p_id)
        {

            List<ProductoEN> ls = new List<ProductoEN>();
            List<Producto> lsProdu = new List<Producto>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = ProductoCAD.GetByPujadosIdPropietario(cnx, p_id);

            foreach (Producto c in lsProdu)
                ls.Add(ProductoBL.ConvertToEN(c));
            return ls;
        }

        public static List<ProductoEN> GetByCompradosIdPropietarioEN(string p_dbCnxStr, int p_id)
        {

            List<ProductoEN> ls = new List<ProductoEN>();
            List<Producto> lsProdu = new List<Producto>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = ProductoCAD.GetByCompradosIdPropietario(cnx, p_id);

            foreach (Producto c in lsProdu)
                ls.Add(ProductoBL.ConvertToEN(c));
            return ls;
        }

        public static List<ProductoEN> GetByUltimosEN(string p_dbCnxStr)
        {

            List<ProductoEN> ls = new List<ProductoEN>();
            List<Producto> lsProdu = new List<Producto>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                
           lsProdu = ProductoCAD.GetByUltimosActivos(cnx);

            foreach (Producto c in lsProdu)
                ls.Add(ProductoBL.ConvertToEN(c));
            return ls;
        }

        public static List<ProductoEN> GetByDestacadosEN(string p_dbCnxStr)
        {
            List<ProductoEN> ls = new List<ProductoEN>();
            List<Producto> lsProdu = new List<Producto>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = ProductoCAD.GetByDestacados(cnx);

            foreach (Producto c in lsProdu)
                ls.Add(ProductoBL.ConvertToEN(c));
            return ls;

        }



        #endregion
        #region Convert To DTO




        private static List<FotosProductoEN> ConvertToListFotosEn(EntitySet<FotosProducto> p_lsFotos)
        {
            if (p_lsFotos == null || p_lsFotos.Count <= 0) //TODO: aqui falla algo
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
                Idproducto = p_fotos.producto//revisar
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
                producto = p_fotos.Idproducto//revisar
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
                foto = prod.Foto,
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
                PrecioSalida = prod.precio_sal,
                PrecioCompra = prod.precio_compra,
                Estado = prod.estado,
                CantidadInicial = prod.cant_ini,
                CantidadRestante = prod.cant_fin,
                FechaFin = prod.fecha_fin,
                Propietario = prod.usuario,
                Subcategoria = prod.subcat,
                Foto = prod.foto,
                Eliminado = prod.eliminado

            };
        }

     
        #endregion


    }
}
