using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteca.Jugo;

namespace Biblioteca
{
    public class Harina: Producto
    {
        protected static bool deConsumo;
        protected ETipoHarina tipo;

        public enum ETipoHarina
        {
            CuatroCeros,
            TresCeros,
            Integral
        }

        public Harina()
        {

        }
        static Harina()
        {
            deConsumo = true;
        }
        public Harina(int codigoDeBarra, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigoDeBarra, marca, precio)
        {
            this.tipo = tipo;
        }
        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)this);
            sb.AppendLine($"De consumo? {deConsumo}");
            sb.AppendLine($"Tipo de harina: {this.tipo}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarHarina();
        }

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (this.precio * 60) / 100;
            }
            set
            {
                this.precio = value;
            }
        }

    }
}
