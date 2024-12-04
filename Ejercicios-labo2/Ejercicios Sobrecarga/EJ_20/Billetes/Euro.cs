using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectodolar;

        static Euro()
        {
            
            Euro.cotizRespectodolar = (Dolar.GetCotizacion() / 1.08);
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectodolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectodolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((e.GetCantidad() / Dolar.GetCotizacion()));
        }
        public static explicit operator Peso(Euro e)
        {
            //return new Peso(e.GetCantidad() * (Peso.GetCotizacion() + 1.08));
            return (Peso)(Dolar)e;
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }



    }
}
