using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Galletita: Producto
    {

        protected static bool deConsumo;
        protected float peso;

        public Galletita()
        {

        }
        static Galletita()
        {
            deConsumo = true;
        }
        public Galletita(int codigoBarra,float precio,EMarcaProducto marca, float peso)
            :base(codigoBarra,marca,precio)
        {
            this.peso = peso;
        }

        private string MostrarGalletita(Galletita galletita)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)galletita);
            sb.AppendLine($"De consumo? {deConsumo}");
            sb.AppendLine($"Peso: {this.peso}");

            return sb.ToString();
        }

        public override string ToString()
        {
            Galletita g = new Galletita();
            return this.MostrarGalletita(g);
        }

        public override string Consumir()
        {
            return "Comestible";
        }
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (this.precio * 33) / 100;
            }
            set
            {
                this.precio = value;
            }
        }
    }
}
