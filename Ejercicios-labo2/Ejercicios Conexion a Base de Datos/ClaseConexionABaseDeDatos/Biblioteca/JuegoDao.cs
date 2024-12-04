using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class JuegoDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;
        
        static JuegoDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static JuegoDto LeerPorId(int codigoJuego)
        {
            JuegoDto juego = null;

            try
            {
                conexion.Open(); // abro conexion
                comando.CommandText = $"SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}"; //armo la consulta
                SqlDataReader dataReader = comando.ExecuteReader();// datareader nos va a devolver la informacion. executeReader ejecuta la consulta.

                while (dataReader.Read()) //recorro el objeto tipo datareader con Read()
                {
                    juego = new JuegoDto(dataReader["NOMBRE"].ToString(),Convert.ToInt32(dataReader["PRECIO"]),dataReader["GENERO"].ToString(),
                        Convert.ToInt32(dataReader["CODIGO_JUEGO"]),Convert.ToInt32(dataReader["CODIGO_USUARIO"]));
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

            return juego;
        }

        //Metodo para guardar
        public static void Guardar(JuegoDto juego)
        {
            try
            {
                comando.Parameters.Clear(); // para limpiar lista de parametros antes de usarla
                conexion.Open();

                //PARA EVITAR INYECCION SQL
                comando.CommandText = $"INSERT INTO JUEGOS (NOMBRE,PRECIO,GENERO,CODIGO_USUARIO) VALUES (@nombre,@precio,@genero,@codigoUsuario)";
                comando.Parameters.AddWithValue("@nombre",juego.Nombre);
                comando.Parameters.AddWithValue("@precio",juego.Precio);
                comando.Parameters.AddWithValue("@genero",juego.Genero);
                comando.Parameters.AddWithValue("@codigoUsuario",juego.CodigoUsuario);

                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        //Metodo para eliminar
        public static void Eliminar(int codigoJuego)
        {
            try
            {
                conexion.Open();

                //PARA EVITAR INYECCION SQL
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";

                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        //Metodo para modificar
        public static void Modificar(JuegoDto juego)
        {
            try
            {
                comando.Parameters.Clear(); // para limpiar lista de parametros antes de usarla
                conexion.Open();

                //PARA EVITAR INYECCION SQL
                comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @nombre, PRECIO = @precio, GENERO = @genero, CODIGO_USUARIO = @codigoUsuario WHERE CODIGO_JUEGO = {juego.CodigoJuego}";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@codigoUsuario", juego.CodigoUsuario);

                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

    }

}

