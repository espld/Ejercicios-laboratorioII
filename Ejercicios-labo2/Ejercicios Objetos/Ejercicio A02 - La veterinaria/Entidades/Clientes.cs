using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {

        /*
         De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. 
        A un cliente se le pueden asociar una o más mascotas.
         */

        private string nombre;
        private string apellido;
        private string telefono;
        private string domicilio;
        private List<Mascota> mascotas;

        public Clientes(string nombre, string apellido, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascotas = new List<Mascota>();            
        }

        public void AgregarMascota(Mascota mascota)
        {
            this.mascotas.Add(mascota); 
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; } 
        }
        public string Telefono 
        { 
            get {  return this.telefono; } 
        }
    
        public string MostrarDatosCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*****CLIENTE*****");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Telefono: {this.Telefono}");
            sb.AppendLine("");
            if(this.mascotas.Count > 1)
            {
                sb.AppendLine("Mascotas:");

                foreach (var mascota in mascotas)
                {
                    sb.AppendLine(mascota.MostrarDatosMascota());
                }

            }
            else
            {
                sb.AppendLine("Mascota:");

                foreach (var mascota in mascotas)
                {
                    sb.AppendLine(mascota.MostrarDatosMascota());
                }
            }
            

            return sb.ToString();
        }


    }
}
