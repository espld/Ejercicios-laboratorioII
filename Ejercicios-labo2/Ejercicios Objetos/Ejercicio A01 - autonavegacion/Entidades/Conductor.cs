using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Conductor
    {

        private string nombre;
        private string apellido;
        private int[] kmRecorridosPorDia;

        public Conductor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.kmRecorridosPorDia = new int[7];
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellido
        {
            get { return apellido; }
        }
        public int[] KmRecorridosPorDia
        {
            get { return this.kmRecorridosPorDia; } }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine("");

            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            for (int i = 0; i < diasSemana.Length; i++)
            {
                sb.AppendLine($"KM recorridos el día {diasSemana[i]}: {kmRecorridosPorDia[i]}");
            }
            sb.AppendLine($"Kilometros recorridos totales: {this.AcumularKmRecorridos()} ");

            //sb.AppendLine($"KM recorridos el día Lunes: {this.kmRecorridosPorDia[0]}");
            //sb.AppendLine($"KM recorridos el día Martes: {this.kmRecorridosPorDia[1]}");
            //sb.AppendLine($"KM recorridos el día Miercoles: {this.kmRecorridosPorDia[2]}");
            //sb.AppendLine($"KM recorridos el día Jueves: {this.kmRecorridosPorDia[3]}");
            //sb.AppendLine($"KM recorridos el día Viernes: {this.kmRecorridosPorDia[4]}");
            //sb.AppendLine($"KM recorridos el día Sabado: {this.kmRecorridosPorDia[5]}");
            //sb.AppendLine($"KM recorridos el día Domingo: {this.kmRecorridosPorDia[6]}");

            return sb.ToString();
        }


        private int AcumularKmRecorridos()
        {
            int acumKm = 0;

            for (int i = 0; i < this.kmRecorridosPorDia.Length; i++)
            {
                acumKm += this.kmRecorridosPorDia[i];
            }

            return acumKm;
        }

        public int KmRecorridoPorDia(int indice)
        {
            int indiceDia = 0 ;

            for (int i = 0; i < this.kmRecorridosPorDia.Length; i++)
            {
                indiceDia = kmRecorridosPorDia[indice];
            }

            return indiceDia;
        }
       
    }
}
