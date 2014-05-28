using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BySWeb.Utilities
{
    public static class Tools
    {
        public static string GetDbCnxStr()
        {
            return "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\TT\\Documents\\GitHub\\bys\\BySWeb\\BySWeb\\App_Data\\BySBD.mdf;Integrated Security=True;User Instance=True";
        }
    }
}