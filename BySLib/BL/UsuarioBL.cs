﻿using BySLib.EN;
using BySLib.LINQ;

namespace BySLib.BL
{
    //Capa de negocio del Usuario
    public class UsuarioBL
    {
        #region CRUD's
        //creaun usuario a partir de un UsuarioEN
        public static void CreateFromEN(string p_dbCnxStr, UsuarioEN p_cli)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                UsuarioCAD.Create(cnx, UsuarioBL.ConvertFromEN(p_cli));

        }

        //Actualiza los datos de un usuario a partir de un UsuarioEN.
        public static bool UpdateFromEN(string p_dbCnxStr, UsuarioEN p_cli)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return UsuarioCAD.Update(cnx, UsuarioBL.ConvertFromEN(p_cli));

        }

        //elimina un usuario de la BD a partir de su ID
        public static bool Delete(string p_dbCnxStr, int p_id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return UsuarioCAD.Delete(cnx, p_id);

        }


        #endregion
        #region Getting Data

        //devuelve un usuario a partir de su ID
        public static UsuarioEN GetByIdToEN(string dbcnx, int id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbcnx))
            {

                return UsuarioBL.ConvertToEN(UsuarioCAD.GetNotDeletedByIdUsuario(cnx, id));

            }

        }
        //devuelve un usuario a parti de su Nick.
        public static UsuarioEN GetUserByNick(string dbcnx, string nick)//revisar hash
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbcnx))
                return UsuarioBL.ConvertToEN(UsuarioCAD.GetUserByNick(cnx, nick));

        }

         public static bool ExisteUser(string p_dbCnxStr, string p_nombre) {

             using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                 return UsuarioCAD.UserExist(cnx, p_nombre);
        
        }

         public static bool ExisteEmail(string p_dbCnxStr, string p_email)
         {

             using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                 return UsuarioCAD.ExistsByEmail(cnx, p_email);

         }


        #endregion
        //Devuelve un Usuario a partir de su UsuarioEN
        internal static Usuario ConvertFromEN(UsuarioEN usu)
        {
            return new Usuario
            {
                id = usu.Id,
                nombre = usu.Nombre,
                nick = usu.Nick,
                mail = usu.Mail,
                password = usu.Password,
                telf = usu.Telf,
                dir = usu.Direccion,
                credito = usu.Credito,
                ruta_img = usu.RutaImg,
                puntuacion = usu.Puntacion,
                punt_total = usu.PuntuacionTotal,
                num_votos = usu.NumeroVotos,
                cod_postal = usu.CodigoPostal,
                nomb_pob = usu.Poblacion,
                eliminado = usu.Eliminado

            };
        }
        //Devuelve un UsuarioEN a partir de un Usuario.
        private static UsuarioEN ConvertToEN(Usuario usu)//revisar
        {
            if(usu== null)
            return new UsuarioEN();

            return new UsuarioEN
            {
                Id = usu.id,
                Nombre = usu.nombre,
                Nick = usu.nick,
                Mail = usu.mail,
                Password = usu.password,
                Telf = usu.telf,
                Direccion = usu.dir,
                Credito = usu.credito,
                RutaImg = usu.ruta_img,
                Puntacion = usu.puntuacion,
                PuntuacionTotal = usu.punt_total,
                NumeroVotos = usu.num_votos,
                CodigoPostal = usu.cod_postal,
                Poblacion = usu.nomb_pob,
                Eliminado = usu.eliminado

            };
        }



    }
}
