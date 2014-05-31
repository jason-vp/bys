using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;
using BySLib.LINQ;
using System.Data.Linq;

namespace BySLib.BL
{
    public static class CompraBL
    {
        #region CRUD's
        public static void Create(string dbCnxStr, CompraEN com)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbCnxStr))
            {
                CompraCAD.Create(cnx, CompraBL.ConvertFromEN(com));
            }
        }

        public static bool UpdateFromEN(string p_dbCnxStr, CompraEN p_com)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return CompraCAD.Update(cnx, CompraBL.ConvertFromEN(p_com));

        }

        public static bool Delete(string p_dbCnxStr, CompraEN p_com)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return CompraCAD.Delete(cnx, CompraBL.ConvertFromEN(p_com));

        }


        #endregion

        #region Getting Data
        public static List<CompraEN> GetByIdPropietarioToEN(string p_dbCnxStr, int p_id)
        {

            List<CompraEN> ls = new List<CompraEN>();
            List<Compra> lsProdu = new List<Compra>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = CompraCAD.GetByIdPropietario(cnx, p_id);

            foreach (Compra c in lsProdu)
                ls.Add(CompraBL.ConvertToEN(c));
            return ls;
        }

        public static List<CompraEN> GetByIdProductoToEN(string p_dbCnxStr, int p_id)
        {

            List<CompraEN> ls = new List<CompraEN>();
            List<Compra> lsProdu = new List<Compra>();

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))

                lsProdu = CompraCAD.GetByIdProducto(cnx, p_id);

            foreach (Compra c in lsProdu)
                ls.Add(CompraBL.ConvertToEN(c));
            return ls;
        }

        #endregion


        #region Convert to EN

        private static List<CompraEN> ConvertToListCompraEn(List<Compra> p_lsCom)//revisar Gamba (es entityset o list)
        {
            if (p_lsCom == null || p_lsCom.Count <= 0)
                return new List<CompraEN>();

            List<CompraEN> ls = new List<CompraEN>();
            foreach (Compra c in p_lsCom)
                ls.Add(ConvertToEN(c));

            return ls;
        }
        private static EntitySet<Compra> ConvertToEntityCompraEn(List<CompraEN> p_lsFotos)
        {
            if (p_lsFotos == null || p_lsFotos.Count <= 0)
                return new EntitySet<Compra>();

            EntitySet<Compra> ls = new EntitySet<Compra>();
            foreach (CompraEN c in p_lsFotos)
                ls.Add(ConvertFromEN(c));

            return ls;
        }



        internal static Compra ConvertFromEN(CompraEN prod)
        {
            return new Compra()
            {
                producto = prod.Producto,
                comprador = prod.Pujador,
                comentario = prod.Comentario,
                puntuacion = prod.Puntuacion,
                fecha = prod.Fecha,
                eliminado = prod.Eliminado

            };
        }

        private static CompraEN ConvertToEN(Compra prod)//revisar
        {
            return new CompraEN()
            {
                Producto = prod.producto,
                Pujador = prod.comprador,
                Comentario = prod.comentario,
                Puntuacion = prod.puntuacion,
                Fecha = prod.fecha,
                Eliminado = prod.eliminado

            };
        }
        #endregion
    }
}
