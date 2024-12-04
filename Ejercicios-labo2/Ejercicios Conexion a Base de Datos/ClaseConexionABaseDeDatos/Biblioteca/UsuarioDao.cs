using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class UsuarioDao
    {
        //CLASE ENCARGADA DE HACER TODA LA CONEXION
        //DAO - DATA ACCESS OBJECT
        //CLASE ENCARGADA DE ACCEDER A LA INFORMACION DE LA TABLA

        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static UsuarioDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion); // clase sqlconnection se encarga de manejar las conexiones a la bdd(abrir,cerrar,etc). Le paso la cadena de conexion.
            comando.Connection = conexion; // La clase comando maneja todo, le paso la conexion. Internamente comando va a manejar todo.
            comando.CommandType = System.Data.CommandType.Text; // para realizar consultas básicas de tipo texto.
        }

        //Metodo para leer una lista de usuarios

        public static List<UsuarioDto> Leer()
        {
            List<UsuarioDto> usuarios = new List<UsuarioDto>();

            try
            {
                conexion.Open(); // abro conexion
                comando.CommandText = "SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS"; //armo la consulta
                SqlDataReader dataReader = comando.ExecuteReader();// datareader nos va a devolver la informacion. executeReader ejecuta la consulta.
               
                while (dataReader.Read()) //recorro el objeto tipo datareader con Read()
                {
                    UsuarioDto usuario = new UsuarioDto(dataReader["USERNAME"].ToString(), Convert.ToInt32(dataReader["CODIGO_USUARIO"]));
                    usuarios.Add(usuario);
                }

                dataReader.Close();
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
