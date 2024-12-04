using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            Peso.cotzRespectoDolar = 1/102;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad,double cotizacion) :this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }

        
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() * Dolar.GetCotizacion());
        }
        public static explicit operator Euro(Peso p)
        {

        }

    }
}
