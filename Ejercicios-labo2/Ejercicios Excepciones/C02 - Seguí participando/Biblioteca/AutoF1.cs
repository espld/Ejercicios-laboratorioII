using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {
        protected short caballosDeFuerza;

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        //propiedades
        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }

        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.CaballosDeFuerza}");

            return sb.ToString();
        }

        //sobrecargas
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


    }
}
