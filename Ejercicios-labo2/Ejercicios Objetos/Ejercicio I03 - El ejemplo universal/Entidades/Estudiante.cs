using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {

        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string nombre,string apellido,string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public int NotaPrimerParcial
        {
            get {  return notaPrimerParcial; }
            set { this.notaPrimerParcial = value; }
        }
        public int NotaSegundoParcial
        {
            set { this.notaSegundoParcial = value; }
        }

        private float CalcularPromedio()
        {
            float promedio;

            promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            return promedio;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = random.Next(6, 10);

            if(this.notaPrimerParcial >=4 && this.notaSegundoParcial >=4)
            {
                return notaFinal;
            }
            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}, Apellido: {this.apellido}, Legajo: {this.legajo}");
            sb.AppendLine($"NotaPP: {this.notaPrimerParcial}, NotaSP:{this.notaSegundoParcial}");
            sb.AppendLine($"Promedio:{CalcularPromedio()}");
            if(CalcularNotaFinal() != -1)
            {
            sb.AppendLine($"Nota Final:{CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine($"Alumno Desaprobado");
            }

            return sb.ToString();
        }

    }
}
