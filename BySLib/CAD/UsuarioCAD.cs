using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BySLib
{
    /// <summary>
    /// Esta clase representa la capa de acceso a datos del usuario
    /// </summary>
    class UsuarioCAD
    {
        /// <summary>
        /// Constante que indica los parámetros de conexión con la DB
        /// </summary>
        //private const string ConnectionString = "Data Source=Videoclub.sqlite;Version=3;New=False;Compress=True;";
        private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Videoclub.mdf;User Instance=true";

        /// <summary>
        /// Representa la entidad de negocio relacionada con el CAD
        /// </summary>
        private UsuarioEN usuario;

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="usuario">Es la entidad de negocio relacionada con este usuario</param>
        public UsuarioCAD(UsuarioEN usuario)
        {
            this.usuario = usuario;
        }

        /// <summary>
        /// Obtiene todos los usuarios de la DB
        /// </summary>
        /// <returns>Vector con los usuarios leidos de la DB</returns>
        public static UsuarioEN[] obtenerTodosUsuarios()
        {
            List<UsuarioEN> usuarios = new List<UsuarioEN>();

            SqlConnection c = new SqlConnection(ConnectionString);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from usuario", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(new UsuarioEN(dr["dni"].ToString(), dr["password"].ToString(), dr["nombre"].ToString(), dr["apellidos"].ToString(),dr["fechaAlta"].ToString()));
            }
            dr.Close();
            c.Close(); 

            return usuarios.ToArray();
        }

        /// <summary>
        /// Obtiene un usuario de la DB por el dni
        /// </summary>
        /// <param name="dni">Es el dni del usuario que se va a obtener</param>
        /// <returns>Devuelve el usuario cuyo dni se pasó por parámetro</returns>
        public static UsuarioEN obtenerUsuarioDni(string dni)
        {
            UsuarioEN usuario = null;

            SqlConnection c = new SqlConnection(ConnectionString);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from usuario where dni="+dni, c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                usuario = new UsuarioEN(dr["dni"].ToString(), dr["password"].ToString(), dr["nombre"].ToString(), dr["apellidos"].ToString(), dr["fechaAlta"].ToString());
            }
            dr.Close();
            c.Close();

            if (usuario == null)
                throw new Exception("No existe ningun usuario por ese dni");

            return usuario;
        }

        /// <summary>
        /// Comprueba si un usuario existe en la DB
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool esUsuario(string dni, string password)
        {
            bool existe = false;

            SqlConnection c = new SqlConnection(ConnectionString);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from usuario where dni=" + dni + " and password='" + password + "'", c); 
            SqlDataReader dr = com.ExecuteReader();

            existe = dr.HasRows;

            dr.Close();
            c.Close();

            return existe;
        }

        /// <summary>
        /// Inserta el Usuario en la DB si no existe o lo actualiza si ya existia
        /// </summary>
        /// <returns>True si se hicieron cambios o se insertó y false en caso contrario</returns>
        public bool insertarActualizar()
        {
            bool aR = false;

            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();

            string consulta = "UPDATE Usuario " +
                             " SET password = '" + usuario.getPassword() +
                               "', nombre = '" + usuario.getNombre() +
                               "', apellidos = '" + usuario.getApellidos() +
                                "' WHERE dni='" + usuario.getDni() + "'";

            SqlCommand com = new SqlCommand(consulta, conexion);

            if (com.ExecuteNonQuery() > 0)
                aR = true;

            conexion.Close();
            

            if (!aR)
            {
                SqlConnection conexion2 = new SqlConnection(ConnectionString);
                conexion2.Open();

                string f = String.Format("{0:yyyy-MM-dd HH:mm:ss}", usuario.getFechaAlta());
                
                string consulta2 = "INSERT into Usuario VALUES (" + usuario.getDni() + ", '" + usuario.getLetraDni() + "', '" +usuario.getPassword() +
                        "', '" + usuario.getNombre() + "', '" + usuario.getApellidos() + "', '" + usuario.getFechaAlta()  + "' )";

                SqlCommand com2 = new SqlCommand(consulta2, conexion2);

                if (com2.ExecuteNonQuery() > 0)
                    aR = true;
                
                conexion2.Close();
            }


            return aR;
        }

        /// <summary>
        /// Borra el usuario actual de la DB
        /// </summary>
        /// <returns>True si se borró y false en caso contrario</returns>
        public bool borrar()
        {
            bool aR = false;


            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();

            string consulta = "DELETE from Usuario WHERE dni='" + usuario.getDni() + "'";

            SqlCommand com2 = new SqlCommand(consulta, conexion);

            if (com2.ExecuteNonQuery() > 0)
                aR = true;

            conexion.Close();

            return aR;
        }
    }
}
