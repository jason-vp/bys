using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BySLib.CAD;
using BySLib.EN;
using BySLib.LINQ;

namespace BySLib.BL
{
    class UsuarioBL
    {


        internal static Usuario ConvertFromEN(UsuarioEN usu)
        {
            return new Usuario()
            {
                id = usu.Id,
                nombre = usu.Nombre,
                nick = usu.Nick,
                mail = usu.Mail,
                password = usu.Password,
                telf = (int)usu.Telf,
                dir = usu.Direccion,
                credito = (decimal)usu.Credito,
                ruta_img = usu.RutaImg,
                puntuacion = (int)usu.Puntacion,
                punt_total = (int)usu.PuntuacionTotal,
                num_votos = (int)usu.NumeroVotos,
                cod_postal = (int)usu.CodigoPostal,
                nomb_pob = usu.Poblacion,
                eliminado = (bool)usu.Eliminado

            };
        }

        private static UsuarioEN ConvertToEN(Usuario usu)//revisar
        {
            return new UsuarioEN()
            {
                Id = usu.id,
                Nombre = usu.nombre,
                Nick = usu.nick,
                Mail = usu.mail,
                Password = usu.password,
                Telf = (int)usu.telf,
                Direccion = usu.dir,
                Credito = (decimal)usu.credito,
                RutaImg = usu.ruta_img,
                Puntacion = (int)usu.puntuacion,
                PuntuacionTotal = (int)usu.punt_total,
                NumeroVotos = (int)usu.num_votos,
                CodigoPostal = (int)usu.cod_postal,
                Poblacion = usu.nomb_pob,
                Eliminado = (bool)usu.eliminado

            };
        }



    }
}
