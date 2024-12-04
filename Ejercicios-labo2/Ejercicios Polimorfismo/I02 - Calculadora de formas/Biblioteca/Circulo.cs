using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class  Circulo: Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI + Math.Pow(this.radio, 2); ;
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * this.radio * 2;
        }

        public override string Dibujar()
        {
            return "Dibujando círculo";
        }

    }
}
