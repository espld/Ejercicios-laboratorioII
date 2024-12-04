using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Local: Llamada
    {
        protected float costo;
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        //Propiedades
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        //Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return (this.duracion * this.costo);
        }

        //Sobrecargas
        public override bool Equals(object? obj)
        {
            return obj is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
