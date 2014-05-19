using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib;


namespace BySLib.EN
{
    /// <summary>
    /// Esta clase representa un Compra de la aplicacion (Entidad de Negocio)
    /// </summary>
    class CompraEN
    {

        #region Private Properties
        private UsuarioEN pujador;
        private ProductoEN producto;
        private TimeSpan fecha;
        private string comentario = "";
        private int puntuacion = 0;
        #endregion

        public CompraEN(UsuarioEN pujador, ProductoEN producto, TimeSpan fecha, string comentario, int puntuacion)
        {
            this.pujador = pujador;
            this.producto = producto;
            this.fecha = fecha;
            this.comentario = comentario;
            this.puntuacion = puntuacion;
        }

        public void Insertar(CompraEN compra_nueva)
        { }

        public void Borrar(CompraEN compra)
        { }

        public void Actualizar(CompraEN compra)
        { }     

        #region Getter y Setters

        /// <summary>
        /// Obtiene al puajador actual
        /// </summary>
        /// <returns>Devuelve el Usuario</returns>
        public UsuarioEN getPujador()
        {
            return pujador;
        }


        /// <summary>
        /// Obtiene el producto actual
        /// </summary>
        /// </returns>Devuelve el Producto</returns>
        public ProductoEN getProducto()
        {
            return producto;
        }


        /// <summary>
        /// Obtiene la fecha de la compra actual
        /// </summary>
        /// </returns>Devuelve la fecha</returns>
        public TimeSpan getFecha()
        {
            return fecha;
        }


        /// <summary>
        /// Obtiene el comentario de la compra
        /// </summary>
        /// </returns>Devuelve el comentario</returns>
        public string getComentario()
        {
            return comentario;
        }


        /// <summary>
        /// Obtiene la puntuacion de la compra
        /// </summary>
        /// </returns>Devuelve la puntuacion</returns>
        public int getPuntuacion()
        {
            return puntuacion;
        }

        /// <summary>
        /// Cambia el pujador de la compra
        /// </summary>
        /// <param name="pujador">Es el nuevo pujador</param>
        public void setUsuario(UsuarioEN pujador)
        {
            this.pujador = pujador;
        }

        /// <summary>
        /// Cambia el producto de la compra
        /// </summary>
        /// <param name="producto">Es el nuevo producto</param>
        public void setProducto(ProductoEN producto)
        {
            this.producto = producto;
        }

        /// <summary>
        /// Cambia la fecha de la compra
        /// </summary>
        /// <param name="fecha">Es la nueva fecha</param>
        public void setFecha(TimeSpan fecha)
        {
            this.fecha = fecha;
        }

        /// <summary>
        /// Cambia el comentario de la compra
        /// </summary>
        /// <param name="comentario">Es el nuevo comentario</param>
        public void setComentario(string comentario)
        {
            this.comentario = comentario;
        }
        

        /// <summary>
        /// Cambia la puntuacion de la compra
        /// </summary>
        /// <param name="puntuacion">Es la nueva puntuacion</param>
        public void setPuntuacion(int puntuacion)
        {
            this.puntuacion = puntuacion;
        }


        #endregion

    }
}
