using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BySLib.Utilities;

namespace BySLib.LINQ
{
   public static class DataContextManager
    {
       public static BySBDDataContext GetOpenedContext(string dbCnxStr)
       {
           SqlConnection cnx = DBConnectionManager.GetOpenedConnection(dbCnxStr);
           return new BySBDDataContext(cnx);
       } 
    }
}
