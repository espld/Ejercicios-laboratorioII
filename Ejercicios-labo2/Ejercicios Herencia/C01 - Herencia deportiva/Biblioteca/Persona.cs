using System.Globalization;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        private long dni;
        private string nombre;

        //propiedades
        public long Dni
        {
            get 
            { 
                return this.dni;
            }
            set { this.dni = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        //constructores
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;
        }

        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
                                         
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Nombre: {this.Nombre}");           

            return sb.ToString();
        }
       
    }
}
