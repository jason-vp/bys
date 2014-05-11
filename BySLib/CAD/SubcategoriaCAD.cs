using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;
namespace BySLib.CAD
{
    /// <summary>
    /// Esta clase representa la capa de acceso a datos del usuario
    /// </summary>
    class SubcategoriaCAD
    {
        /// <summary>
        /// Constante que indica los parámetros de conexión con la DB
        /// </summary>
        //private const string ConnectionString = "Data Source=Videoclub.sqlite;Version=3;New=False;Compress=True;";
        private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Videoclub.mdf;User Instance=true";

        /// <summary>
        /// Variable privada que representa la Entidad de Negocio de la subcategoria
        /// </summary>
        private SubcategoriaEN cat;

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="cat">Entidad de negocio de l anueva categoria</param>
        public SubcategoriaCAD(SubcategoriaEN cat)
        {
            this.cat = cat;
        }

        /// <summary>
        /// Devuelve la subcategoria cuyo id se corresponde con el que se pasa por parametro
        /// </summary>
        /// <param name="id">id de la subcategoria</param>
        /// <returns>subcategoria con el mismo id que el pasado por parametro</returns>
        public SubcategoriaEN ObtenerPorID(int id)
        {

        }

        /// <summary>
        /// Actualiza la BD
        /// </summary>
        public void Actualizar()
        {

        }

        /// <summary>
        /// Devuelve una lista de todas las Subcategorias
        /// </summary>
        /// <returns>lista de todas las Subcategorias</returns>
        public CategoriaEN[] listarSubcategoria()
        {

        }

        /// <summary>
        /// Inserta una nueva Subcategoria en la BD
        /// </summary>
        /// <param name="nuevaCat">Entidad de negocio de la nueva Subcategoria</param>
        public void Insertar(SubcategoriaEN nuevaCat)
        {

        }

        /// <summary>
        /// Borra de la BD la subcategoria cuyo id se corresponde con el que se pasa por parametro
        /// </summary>
        /// <param name="id">id subcategoria</param>
        public void BorrarSubCat(int id)
        {

        }
    }
}
