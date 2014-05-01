using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BySLib;

namespace BySLib.EN
{
    class CategoriaEN
    {
        #region Private Properties
        private int id;
        private string nombre = "";
        #endregion

        public CategoriaEN(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int GetId()
        {
            return id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }



        public void Insertar(CategoriaEN nuevaCat)
        {

        }

        public void Actualizar()
        {

        }

        public void BorrarCat(int id)
        {

        }
    }
}
