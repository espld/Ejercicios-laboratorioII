using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotoCross: VehiculoDeCarrera
    {

        protected short cilindrada;

        public MotoCross(short numero,string escuderia)
            :base(numero, escuderia)
        {
        }
        public MotoCross(short numero, string escuderia, short cilindrada)
            :this(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }

        //propiedades
        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        
        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            
            return sb.ToString();
        }

        //sobrecargas
        public static bool operator ==( MotoCross m1, MotoCross m2)
        {
            return m1.Cilindrada == m2.Cilindrada;
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }


    }
}
