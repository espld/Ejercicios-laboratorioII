using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class PersonaDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static PersonaDAO()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static void Guardar(Persona p)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();

                comando.CommandText = "INSERT INTO PERSONA (NOMBRE,APELLIDO) VALUES (@NOMBRE,@APELLIDO)";
                comando.Parameters.AddWithValue("@NOMBRE", p.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO", p.Apellido);

                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT ID,NOMBRE,APELLIDO FROM PERSONA";
                SqlDataReader dataReader = comando.ExecuteReader();

                while(dataReader.Read())
                {
                    Persona persona = new Persona(Convert.ToInt32(dataReader["ID"]), dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString());
                    personas.Add(persona);
                }
                dataReader.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return personas;
        }
        
        public static Persona LeerPorId(int idPersona)
        {
            Persona persona = null;

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM PERSONA WHERE ID = {idPersona}";
                SqlDataReader dataReader = comando.ExecuteReader();

                while(dataReader.Read())
                {
                    persona = new Persona(Convert.ToInt32(dataReader["ID"]), dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString());

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
            return persona;
        }
        public static void Eliminar(int idPersona)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM PERSONA WHERE ID = {idPersona}";

                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static void Modificar(Persona p)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();

                comando.CommandText = $"UPDATE PERSONA SET NOMBRE = @NOMBRE, APELLIDO = @APELLIDO WHERE ID = {p.Id}";
                comando.Parameters.AddWithValue("@NOMBRE",p.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO",p.Apellido);

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
