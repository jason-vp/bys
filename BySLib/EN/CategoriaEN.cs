using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BySLib;

namespace BySLib.EN
{
    /// <summary>
    /// Esta clase representa un Usuario de la aplicacion (Entidad de negocio)
    /// </summary>
    class CategoriaEN
    {
        #region Private Properties
        private int id;
        private string nombre = "";
        #endregion

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="id">id de la categoria</param>
        /// <param name="nombre">nombre de la categoria</param>
        public CategoriaEN(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        /// <summary>
        /// Getter id
        /// </summary>
        /// <returns>id categoria</returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Getter nombre
        /// </summary>
        /// <returns>nombre categoria</returns>
        public string GetNombre()
        {
            return nombre;
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
        /// Inserta la nueva categoria en la BD
        /// </summary>
        /// <param name="nuevaCat">nueva categoria</param>
        public void Insertar(CategoriaEN nuevaCat)
        {

        }

        /// <summary>
        /// Actualiza la BD
        /// </summary>
        public void Actualizar()
        {

        }

        /// <summary>
        /// Borra la categoria cuyo id se corresponde con el pasado por parametro 
        /// </summary>
        /// <param name="id">id de la categoria</param>
        public void BorrarCat(int id)
        {

        }
    }
}
