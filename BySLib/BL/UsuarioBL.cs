using BySLib.EN;
using BySLib.LINQ;

namespace BySLib.BL
{
    public class UsuarioBL
    {
        #region CRUD's
        public static void CreateFromEN(string p_dbCnxStr, UsuarioEN p_cli)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                UsuarioCAD.Create(cnx, UsuarioBL.ConvertFromEN(p_cli));

        }

        public static bool UpdateFromEN(string p_dbCnxStr, UsuarioEN p_cli)
        {
            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return UsuarioCAD.Update(cnx, UsuarioBL.ConvertFromEN(p_cli));

        }

        public static bool Delete(string p_dbCnxStr, int p_id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(p_dbCnxStr))
                return UsuarioCAD.Delete(cnx, p_id);

        }


        #endregion
        #region Getting Data

        public static UsuarioEN GetByIdToEN(string dbcnx, int id)
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbcnx))
            {

                return UsuarioBL.ConvertToEN(UsuarioCAD.GetNotDeletedByIdUsuario(cnx, id));

            }

        }

        public static UsuarioEN GetUserByNick(string dbcnx, string nick)//revisar hash
        {

            using (BySBDDataContext cnx = DataContextManager.GetOpenedContext(dbcnx))
                return UsuarioBL.ConvertToEN(UsuarioCAD.GetUserByNick(cnx, nick));

        }


        #endregion
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
