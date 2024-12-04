using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_16
{
    internal class Alumno
    {
        //PROPIEDADES

        private byte nota1;
        private byte nota2;
        private float notafinal;
        private Random random = new Random();
        public string apellido;
        public int legajo;
        public string nombre;

        private void SetNotaUno(byte nota)
        {
            this.nota1 = nota;
        }

        private void SetNotaDos(byte nota)
        {
            this.nota2 = nota;
        }

        //METODOS

        private void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notafinal = (this.nota1 + this.nota2) / 2;
                
            }
            else
            {
                this.notafinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            SetNotaUno(notaUno);
            SetNotaDos(notaDos);
        }

        public string Mostrar()
        {
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota 1: {this.nota1}");
            sb.AppendLine($"Nota 2: {this.nota2}");
            this.CalcularFinal();
            if(this.notafinal != -1)
            {
                sb.AppendLine($"Nota Final: {this.notafinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();

        }



    }
}
