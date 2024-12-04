using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class JuegoDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static JuegoDAO()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego juego = null;

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";
                SqlDataReader lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    juego = new Juego(lector["NOMBRE"].ToString(), Convert.ToInt32(lector["PRECIO"]), lector["GENERO"].ToString(), Convert.ToInt32(lector["CODIGO_JUEGO"]), Convert.ToInt32(lector["CODIGO_USUARIO"]));
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

            return juego;
        }
        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> biblioteca = new List<Biblioteca>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT JUEGOS.NOMBRE as juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, JUEGOS.PRECIO as precio, USUARIOS.USERNAME as usuario\r\nFROM JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        biblioteca.Add(new Biblioteca(dataReader["usuario"].ToString(), dataReader["genero"].ToString(), dataReader["juego"].ToString(), Convert.ToInt32(dataReader["precio"]),
                          Convert.ToInt32(dataReader["codigoJuego"])));
                    }
                }

            }
            finally
            {
                conexion.Close();
            }

            return biblioteca;
        }

        public static void Guardar(Juego juego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = "INSERT INTO JUEGOS(NOMBRE,PRECIO,GENERO,CODIGO_USUARIO) VALUES(@nombre,@precio,@genero,@codigousuario)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre",juego.Nombre);
                comando.Parameters.AddWithValue("@precio",juego.Precio);
                comando.Parameters.AddWithValue("@genero",juego.Genero);
                comando.Parameters.AddWithValue("@codigousuario",juego.CodigoUsuario);

                comando.ExecuteNonQuery();
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
        public static void Modificar(Juego juego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @nombre, PRECIO = @precio, GENERO = @genero, CODIGO_USUARIO = @codigousuario WHERE CODIGO_JUEGO = {juego.CodigoJuego}";
                
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre",juego.Nombre);
                comando.Parameters.AddWithValue("@precio",juego.Precio);
                comando.Parameters.AddWithValue("@genero",juego.Genero);
                comando.Parameters.AddWithValue("@codigousuario",juego.CodigoUsuario);

                comando.ExecuteNonQuery();
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
        public static void Eliminar(int codigoJuego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";
                comando.ExecuteNonQuery();
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
