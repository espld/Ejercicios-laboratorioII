using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gaseosa: Producto
    {
        protected static bool deConsumo;
        protected float litros;

        public Gaseosa()
        {

        }
        static Gaseosa()
        {
            deConsumo = true;
        }
        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoBarra, marca, precio)
        {
            this.litros = litros;
        }
        public Gaseosa(Producto producto,float litros)
            :this(producto.CodigoDeBarra,producto.Precio,producto.Marca,litros)
        {

        }
        
        private string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)this);
            sb.AppendLine($"De consumo? {deConsumo}");
            sb.AppendLine($"Litros: {this.litros}");

            return sb.ToString();
        }
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (this.precio * 42) / 100;
            }
            set
            {
                this.precio = value;
            }
        }
        public override string ToString()
        {
            return this.MostrarGaseosa();
        }
        public override string Consumir()
        {
            return "Bebible";
        }

    }
}
