using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib;

namespace BySLib.EN
{
    class SubcategoriaEN
    {
        
        #region Private Properties
        private int id;
        private string nombre = "";
        private CategoriaEN padre;
        #endregion

        public SubcategoriaEN(int id, string nombre, CategoriaEN cat)
        {
            this.id = id;
            this.nombre = nombre;
            padre = cat;
        }

        public int GetId()
        {
            return id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public CategoriaEN getPadre()
        {
            return padre;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setPadre(CategoriaEN cat)
        {
            padre = cat;
        }

        public void Insertar(SubcategoriaEN nuevaCat)
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
