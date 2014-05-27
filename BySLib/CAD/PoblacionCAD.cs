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
    public static class PoblacionCAD
    {

        public static List<Poblacion> GetByPostalCode(BySBDDataContext p_ctx, int p_pc)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

            //#endregion

            return (from t1 in p_ctx.Poblacion
                    where t1.cod_postal == p_pc
                    select t1).ToList();

        }
        
    }
}