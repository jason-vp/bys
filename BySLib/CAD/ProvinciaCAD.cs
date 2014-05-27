using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Text;
using BySLib.EN;
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