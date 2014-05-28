using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;

namespace BySLib.AUXILIAR
{
    public class Validacion
    {
        public static bool isEmail(string s)
        {
            string sPattern = "^[a-z0-9._%-]+@[a-z0-9.-]+\\.[a-z]{2,4}$";

            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }

        //6-12, 1 minuscula, 1 mayuscula, 1 minuscula
        public static bool isPassword(string s) 
        {
            string sPattern = "^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{6,12}$";

            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }

        public static bool isNombre(string s)
        {
            string sPattern = "^[a-zA-ZÀ-ÖØ-öø-ÿ]+\\.?(( |\\-)[a-zA-ZÀ-ÖØ-öø-ÿ]+\\.?)*$";
        
            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }

        public static bool isDireccion(string s) // Formato: Calle Numero Numero
        {
            string sPattern = "^.{1,40}$";

            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }

        public static bool isTelefono(string s)
        {
            string sPattern = "^0{0,2}([\\+]?[\\d]{1,3} ?)?([\\(]([\\d]{2,3})[)] ?)?[0-9][0-9 \\-]{6,}( ?([xX]|([eE]xt[\\.]?)) ?([\\d]{1,5}))?$";

            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }

        public static bool isCpostal(string s)
        {
            string sPattern = "^\\d{5}$";

            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }

        public static bool isTarjeta(string s)
        {
            string sPattern = "^\\d{4}$";

            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }

        public static bool isMes(string s)
        {
            string sPattern = "^01|02|03|04|05|06|07|08|09|10|11|12$";

            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }

        public static bool isAnyo(string s)
        {
            string sPattern = "^\\d{2}$";

            return System.Text.RegularExpressions.Regex.IsMatch(s, sPattern);
        }
    }
}
