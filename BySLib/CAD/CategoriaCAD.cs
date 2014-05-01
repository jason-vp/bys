using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;

namespace BySLib.CAD
{
    class CategoriaCAD
    {
        private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Videoclub.mdf;User Instance=true";
        private CategoriaEN cat;

        public CategoriaCAD(CategoriaEN cat)
        {
            this.cat = cat;
        }
   
        public CategoriaEN ObtenerPorID(int id)
        {

        }

        public void Actualizar()
        {

        }

        public CategoriaEN[] listarCategorias()
        {

        }

        public void Insertar(CategoriaEN nuevaCat)
        {

        }

        public void BorrarCat(int id)
        {

        }
    }
}
