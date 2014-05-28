using System.Linq;
using BySLib.LINQ;


namespace BySLib
{
    public static class ProvinciaCAD
    {

        public static Provincia GetById(BySBDDataContext p_ctx, int p_id)
        {

            return (from t1 in p_ctx.Provincia
                    where t1.cod_prov == p_id
                    select t1).SingleOrDefault();

        }

    }
}