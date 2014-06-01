using BySLib.EN;
using BySLib.LINQ;

namespace BySLib.BL
{
    //Capa de negocio de la puja
    public static class PujaBL
    {
        #region CRUD's
        //Crea una puja a prtir de un PujaEN
        public static void CreateFromEN(string p_dbCnxStr, PujaEN p_cli)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                PujaCAD.Create(cnx, PujaBL.ConvertFromEN(p_cli));

        }

        //Actualiza los datos de una puja a partir de un PujaEN
        public static bool UpdateFromEN(string p_dbCnxStr, PujaEN p_cli)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return PujaCAD.Update(cnx, PujaBL.ConvertFromEN(p_cli));

        }


        #endregion

        //Devuelve la ultima puja de un producto a partir de su id.
        public static PujaEN GetLastPujaByProductoId(string p_dbCnxStr, int idprod)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return PujaBL.ConvertToEN(PujaCAD.GetByIdProducto(cnx, idprod));

        }

        //Devuelve una puja a partir de un PujaEN.
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

        //Devuelve un PujaEN a partir de una Puja
        private static PujaEN ConvertToEN(Puja prod)//revisar
        {
            if (prod == null)
                return new PujaEN();

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
