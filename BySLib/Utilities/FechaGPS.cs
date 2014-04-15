using System;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace BySLib.Utilities
{
    /// <summary>
    /// Fecha en formato GPS
    /// </summary>
    public class FechaGPS : Object, IDisposable, IComparable
    {

        #region Miembros de IDisposable
        private bool disposed = false;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                }
            }
            this.disposed = true;
        }
        ~FechaGPS()
        {
            this.Dispose(false);
        }
        #endregion

        #region IComparable
        public int CompareTo(object obj)
        {
            FechaGPS f = obj as FechaGPS;
            return this.GPS.CompareTo(f.GPS);
        }
        #endregion
        public const string SINFECHAGPS = "19000101000001";
        public const string SINFECHA = "01.01.1900 00:00:01";
        public const string DIASINFECHA = "01.01.1900";
        public const string DIASINFECHAGPS = "19000101";

        private string fecha = FechaGPS.SINFECHAGPS;
        public string GPS
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        public string CanonicaGrid
        {
            get
            {
                return new FechaGPS(fecha).toCanonicaShort();
            }
            set
            {
                fecha = value;
            }
        }

        public string CanonicaGridExtended
        {
            get
            {
                return new FechaGPS(fecha).toCanonicaODBC();
            }
            set
            {
                fecha = value;
            }
        
        }

        /// <summary>
        /// Devuelve la fecha en formato GPS, esto es YYYYMMDDHHMMSS.
        /// </summary>
        public string AsGPS()
        {
            return this.fecha;
        }
        /// <summary>
        /// Devuelve una cadena con la fecha en formato canónico, esto es dd/mm/yyyy hh:mm:ss.
        /// </summary>
        private string toCanonica()
        {
            string[] parts = new string[] {this.fecha.Substring(6, 2), this.fecha.Substring(4, 2), 
                                     this.fecha.Substring(0, 4), this.fecha.Substring(8, 2), 
                                     this.fecha.Substring(10, 2), this.fecha.Substring(12, 2)};

            return String.Format("{0}.{1}.{2} {3}:{4}:{5}", parts);
        }
        private string toCanonicaODBC()
        {
            string[] parts = new string[] {this.fecha.Substring(0, 4),this.fecha.Substring(4, 2), 
                                      this.fecha.Substring(6, 2), this.fecha.Substring(8, 2), 
                                     this.fecha.Substring(10, 2), this.fecha.Substring(12, 2)};

            return String.Format("{0}.{1}.{2} {3}:{4}:{5}", parts);
        }

        private string toCanonicaShort()
        {
            string[] parts = new string[] {this.fecha.Substring(0, 4),this.fecha.Substring(4, 2), 
                                      this.fecha.Substring(6, 2)};

            return String.Format("{0}.{1}.{2}", parts);
        }
        /// <summary>
        /// Devuelve la fecha en formato canónico, esto es dd/mm/yyyy hh:mm:ss.
        /// </summary>
        public string AsCanonica() { return this.toCanonica(); }
        /// <summary>
        /// Devuelve el dia de la fecha en formato GPS, esto es YYYYMMDD.
        /// </summary>
        public string AsDiaGPS() { return this.fecha.Substring(0, 8); }
        /// <summary>
        /// Devuelve el día de la fecha en formato canonico, esto es dd/mm/yyyy
        /// </summary>
        public string AsDiaCanonico()
        {
            string[] parts = new string[] {this.fecha.Substring(6, 2), this.fecha.Substring(4, 2), 
                                     this.fecha.Substring(0, 4)};
            return String.Format("{0}.{1}.{2}", parts);
        }

        public DateTime AsDateTime()
        {
            IFormatProvider format = new CultureInfo("es-ES");
            return Convert.ToDateTime(this.toCanonica(), format);
        }

        public static FechaGPS ParseStringToFechaGPS(string gpsString)
        {
            return new FechaGPS(gpsString);
        }

        #region Constructores
        public FechaGPS() :
            this(FechaGPS.SINFECHAGPS) { }

        public FechaGPS(string gpsString)
        {
            DateTime res;
            if ((gpsString.Length != 14) || (!Information.IsNumeric(gpsString)))
            {
                throw new ArgumentException("La cadena '" + gpsString + "' no es una Fecha GPS válida.");
            }

            this.fecha = gpsString;
            IFormatProvider format = new CultureInfo("es-ES");
            if (!DateTime.TryParse(this.toCanonica(), format, DateTimeStyles.None, out res))
            {
                throw new ArgumentException("La cadena '" + gpsString + "' no es una Fecha GPS válida.");
            }
        }
        public FechaGPS(DateTime fecha) :
            this(string.Format("{0:yyyyMMddHHmmss}", fecha)) { }
        #endregion

        public override string ToString()
        {
            return this.toCanonicaODBC();
        }

        public static string GetNowAsFechaGPS()
        {
            return string.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
        }


        public string ToShorDate()
        {
            return this.toCanonicaShort();
        }



    }

}

