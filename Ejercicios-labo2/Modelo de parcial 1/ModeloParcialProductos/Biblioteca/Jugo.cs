using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugo: Producto
    {

        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }
        protected static bool deConsumo;
        protected ESaborJugo sabor;

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (this.precio * 40) / 100;
            }
            set
            {
                this.precio = value;
            }
        }

        static Jugo()
        {
            deConsumo = true;
        }
        public Jugo(int codigoDeBarra,float precio,EMarcaProducto marca,ESaborJugo sabor)
            :base(codigoDeBarra,marca,precio)
        {
            this.sabor = sabor;
        }

        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)this);
            sb.AppendLine($"De consumo? {deConsumo}");
            sb.AppendLine($"Sabor: {this.sabor}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarJugo();
        }
        public override string Consumir()
        {
            return "Bebible";
        }

    }
}
