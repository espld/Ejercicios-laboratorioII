using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        /*
         De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación.
        Los primeros tres datos son obligatorios para dar de alta una mascota,
         */

        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string vacunacion;

        public Mascota()
        {

        }
        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Especie
        {
            get { return this.especie; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
        }

        public string Vacunacion
        {
            get 
            { 
                if(this.vacunacion == null)
                {
                    return "No tiene vacunas.";
                }
                return this.vacunacion; 
            }
            set { this.vacunacion = value;}
        }

        public string MostrarDatosMascota()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Especie: {this.Especie}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Nacimiento: {this.FechaNacimiento.ToString("dd/MM/yyyy")}");
            if(this.Vacunacion != null)
            {
                sb.AppendLine($"Vacunas: {this.Vacunacion}");
            }
           
            return sb.ToString();
        }

    }
}
