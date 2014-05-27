using System;
namespace BySLib.LINQ
{
    partial class BySBDDataContext
    {

        private System.Data.SqlClient.SqlConnection _Connection = null;

        public BySBDDataContext(System.Data.SqlClient.SqlConnection Connection)
            : base(Connection)
        {
            // Only set the reference if the connection is Valid and Open during construction
            if (Connection != null)
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    _Connection = Connection;
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                try
                {
                    if (_Connection != null)
                    {
                        _Connection.Close();
                        _Connection.Dispose();
                    }
                }
                catch { }
                base.Dispose(disposing);
                GC.Collect();
            }
            catch { }
        }

    }
}
