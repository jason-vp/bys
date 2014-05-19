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
    class CategoriaCAD
    {
        /// <summary>
        /// Constante que indica los parámetros de conexión con la DB
        /// </summary>
        //private const string ConnectionString = "Data Source=Videoclub.sqlite;Version=3;New=False;Compress=True;";
        private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Videoclub.mdf;User Instance=true";

        private CategoriaEN cat;

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="cat">Nueva categoria</param>
        public CategoriaCAD(CategoriaEN cat)
        {
            this.cat = cat;
        }

        /// <summary>
        /// Devuelve la categoria cuyo id se corresponde con el que se pasa por parametro
        /// </summary>
        /// <param name="id">id de la categoria</param>
        /// <returns>categoria con el mismo id que el pasado por parametro</returns>
        public CategoriaEN ObtenerPorID(int id)
        {
            return null;
        }

        /// <summary>
        /// Actualiza la BD
        /// </summary>
        public void Actualizar()
        {

        }

        /// <summary>
        /// Devuelve una lista de todas las categorias
        /// </summary>
        /// <returns>lista de todas las categorias</returns>
        public CategoriaEN[] listarCategorias()
        {
            return null;
        }

        /// <summary>
        /// Inserta una nueva Subcategoria en la BD
        /// </summary>
        /// <param name="nuevaCat">Entidad de negocio de la nueva categoria</param>
        public void Insertar(CategoriaEN nuevaCat)
        {

        }

        /// <summary>
        /// Borra de la BD la categoria cuyo id se corresponde con el que se pasa por parametro
        /// </summary>
        /// <param name="id">id categoria</param>
        public void BorrarCat(int id)
        {

        }
    }
}
