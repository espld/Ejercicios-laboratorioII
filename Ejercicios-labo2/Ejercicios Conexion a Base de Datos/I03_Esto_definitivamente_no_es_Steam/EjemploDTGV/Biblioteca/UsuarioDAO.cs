using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class UsuarioDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static UsuarioDAO()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = null;
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT USERNAME,CODIGO_USUARIO FROM USUARIOS";
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    {
                        usuario = new Usuario(lector["USERNAME"].ToString(), Convert.ToInt32(lector["CODIGO_USUARIO"]));
                        usuarios.Add(usuario);
                    }
                }
                lector.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return usuarios;
        }

    }
}
