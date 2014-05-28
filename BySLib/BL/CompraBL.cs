using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;
using BySLib.LINQ;

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

    }
}
