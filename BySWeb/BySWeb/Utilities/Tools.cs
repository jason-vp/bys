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
            return "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|BySBD.mdf;Integrated Security=True;User Instance=True";
            // return "Server=localhost; Port=3950; Database=BySBD; Uid=root; Pwd=;"; C:\\Users\\TT\\Documents\\GitHub\\bys\\BySWeb\\BySWeb\\App_Data
       
        
        }
    }
}