using System;
using System.Data.SqlClient;

namespace BySLib.Utilities
{
    public class DBConnectionManager
    {
        public static SqlConnection GetConnection()
        {
            string cnx = "Server=localhost; Port=3306; Database=BySBD; Uid=root; Pwd=;"; //modificar
            return DBConnectionManager.GetClosedConnection(cnx);
        }
        public static SqlConnection GetOpenedConnection(string cnxString)
        {
            SqlConnection my = new SqlConnection(cnxString);
       

            my.Open();
            return my;
        }

        public static SqlConnection GetClosedConnection(string cnxString)
        {
            return new SqlConnection(cnxString);
        }
    }

}