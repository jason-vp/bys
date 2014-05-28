using BySLib.EN;
using BySLib.LINQ;

namespace BySLib.BL
{
    public static class PujaBL
    {
        #region CRUD's
        public static void CreateFromEN(string p_dbCnxStr, PujaEN p_cli)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                PujaCAD.Create(cnx, PujaBL.ConvertFromEN(p_cli));

        }

        public static bool UpdateFromEN(string p_dbCnxStr, PujaEN p_cli)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return PujaCAD.Update(cnx, PujaBL.ConvertFromEN(p_cli));

        }


        #endregion


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
                Valor = prod.valor,
                Fecha = prod.fecha,
                Estado = prod.estado
              

            };
        }
    }
}
