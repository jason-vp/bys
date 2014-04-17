using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN
namespace BySLib.CAD
{
    class SubcategoriaCAD
    {
                private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Videoclub.mdf;User Instance=true";
        private SubcategoriaEN cat;

        public SubcategoriaCAD(SubcategoriaEN cat)
        {
            this.cat = cat;
        }
   
        public SubcategoriaEN ObtenerPorID(int id)
        {

        }

        public void Actualizar()
        {

        }

        public CategoriaEN[] listarSubcategoria()
        {

        }

        public void Insertar(SubcategoriaEN nuevaCat)
        {

        }

        public void BorrarCat(int id)
        {

        }
    }
}
