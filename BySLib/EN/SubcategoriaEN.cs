using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib;

namespace BySLib.EN
{
    /// <summary>
    /// Esta clase representa un Usuario de la aplicacion (Entidad de negocio)
    /// </summary>
    class SubcategoriaEN
    {
        
        #region Private Properties
        private int id;
        private string nombre = "";
        private CategoriaEN padre;
        #endregion

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="id">id de la subcategoria</param>
        /// <param name="nombre">nombre de la subcategoria</param>
        public SubcategoriaEN(int id, string nombre, CategoriaEN cat)
        {
            this.id = id;
            this.nombre = nombre;
            padre = cat;
        }

        /// <summary>
        /// Getter id
        /// </summary>
        /// <returns>id subcategoria</returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Getter nombre
        /// </summary>
        /// <returns>nombre subcategoria</returns>
        public string GetNombre()
        {
            return nombre;
        }

        /// <summary>
        /// Getter padre
        /// </summary>
        /// <returns>Categoria padre</returns>
        public CategoriaEN getPadre()
        {
            return padre;
        }

        /// <summary>
        /// Setter id
        /// </summary>
        /// <param name="id">nuevo id</param>
        public void setId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Setter nombre
        /// </summary>
        /// <param name="nombre">nuevo nombre</param>
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Setter padre
        /// </summary>
        /// <param name="cat">nueva categoria padre</param>
        public void setPadre(CategoriaEN cat)
        {
            padre = cat;
        }

        /// <summary>
        ///Inserta una nueva subcategoria en la BD
        /// </summary>
        /// <param name="nuevaCat">nueva subcategoria</param>
        public void Insertar(SubcategoriaEN nuevaCat)
        {

        }

        /// <summary>
        /// Actualiza la BD
        /// </summary>
        public void Actualizar()
        {

        }

        /// <summary>
        /// Borra la Subcategoria cuyo id se corresponde con la pasada por parametro
        /// </summary>
        /// <param name="id">id subcategoria</param>
        public void BorrarCat(int id)
        {

        }
    }
}
