using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.EN;
using BySLib.LINQ;

namespace BySLib.BL
{
    public static class CompraBL
    {

        internal static Compra ConvertFromEN(CompraEN prod)
        {
            return new Compra()
            {
                producto = prod.Producto,
                comprador = prod.Pujador,
                comentario = prod.Comentario,
                puntuacion = prod.Puntuacion,
                fecha = prod.Fecha,
                eliminado = prod.Eliminado

            };
        }

        private static CompraEN ConvertToEN(Compra prod)//revisar
        {
            return new CompraEN()
            {
                Producto = prod.producto,
                Pujador = prod.comprador,
                Comentario = prod.comentario,
                Puntuacion = (int)prod.puntuacion,
                Fecha = prod.fecha,
                Eliminado = prod.eliminado

            };
        }

    }
}
