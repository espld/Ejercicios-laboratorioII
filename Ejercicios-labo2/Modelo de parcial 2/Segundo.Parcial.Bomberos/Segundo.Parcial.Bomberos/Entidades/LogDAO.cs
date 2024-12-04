using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LogDAO
    {
        private string cadenaConexion;
        private SqlCommand comando;
        private SqlConnection conexion;

        public LogDAO()
        {
            cadenaConexion = @"Data Source=. ;Initial Catalog= bomberos-db ;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public void InsertarLog(string mensaje)
        {
            try
            {
                conexion.Open();

                comando.CommandText = $"INSERT INTO dbo.log (entrada,alumno) values (@entrada,'asd')";
                comando.Parameters.AddWithValue("@entrada", mensaje);

                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public string LeerLog()
        {
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT entrada FROM dbo.log";
                SqlDataReader lector = comando.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                if(lector.Read())
                {
                    sb.AppendLine(lector["entrada"].ToString());
                }
                return sb.ToString();
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
