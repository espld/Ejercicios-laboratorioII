using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {

        private double cantidad;
        private static double cotizRespectodolar;

        static Dolar()
        {
            Dolar.cotizRespectodolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectodolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectodolar;
        }
      
        public static explicit operator Euro (Dolar d)
        {
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.GetCantidad() * Peso.GetCotizacion());
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
           return d == e;
        }
        public static bool operator !=(Dolar d , Euro e)
        {
            return !(d == e);
        }


    }
}
