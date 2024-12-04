using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        private float longitudBase;
        private float longitudAltura;

        public Rectangulo(float longitudBase, float longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }
        public override double CalcularArea()
        {
            return this.longitudBase * this.longitudAltura;

        }

        public override double CalcularPerimetro()
        {
            return (this.longitudBase + this.longitudAltura) * 2;
        }

        public override string Dibujar()
        {
            return "Dibujando rectángulo....";
        }


    }
}
