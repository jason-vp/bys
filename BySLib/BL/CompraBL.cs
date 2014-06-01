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
        //Crea una compra a partir de una compraEN
        public static void Create(string dbCnxStr, CompraEN com)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbCnxStr))
            {
                CompraCAD.Create(cnx, CompraBL.ConvertFromEN(com));
            }
        }
        //Actualiza una compra a partir de un compraEN.
        public static bool UpdateFromEN(string p_dbCnxStr, CompraEN p_com)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return CompraCAD.Update(cnx, CompraBL.ConvertFromEN(p_com));

        }

        //Elimina una compra de la BD
        public static bool Delete(string p_dbCnxStr, CompraEN p_com)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return CompraCAD.Delete(cnx, CompraBL.ConvertFromEN(p_com));

        }


        #endregion

        #region Getting Data
        //Obtiene una lista de compraEN a partir de la id de un propietario.
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

        //Devuelve un objeto ProductoEN a partir de una ID
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
        //devuelve una lista de CompraEN a partir de una lista de Compras
        private static List<CompraEN> ConvertToListCompraEn(List<Compra> p_lsCom)//revisar Gamba (es entityset o list)
        {
            if (p_lsCom == null || p_lsCom.Count <= 0)
                return new List<CompraEN>();

            List<CompraEN> ls = new List<CompraEN>();
            foreach (Compra c in p_lsCom)
                ls.Add(ConvertToEN(c));

            return ls;
        }
        //Devuelve un EntitySet de compra a partir de una CompraEN.
        private static EntitySet<Compra> ConvertToEntityCompraEn(List<CompraEN> p_lsFotos)
        {
            if (p_lsFotos == null || p_lsFotos.Count <= 0)
                return new EntitySet<Compra>();

            EntitySet<Compra> ls = new EntitySet<Compra>();
            foreach (CompraEN c in p_lsFotos)
                ls.Add(ConvertFromEN(c));

            return ls;
        }


        Devuelve una compra a partir de una CompraEN
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
        //Devuelve una compraEN a partir de una Compra
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
