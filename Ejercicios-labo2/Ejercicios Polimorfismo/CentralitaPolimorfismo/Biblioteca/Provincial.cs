using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Provincial: Llamada
    {
        public enum EFranja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected EFranja franjaHoraria;

        public Provincial(EFranja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, EFranja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
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
            sb.AppendLine($"Franja Horaria: {this.franjaHoraria}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            if (this.franjaHoraria == EFranja.Franja_1)
            {
                return (this.duracion * 0.99f);
            }
            else if (this.franjaHoraria == EFranja.Franja_2)
            {
                return (this.duracion * 1.25f);
            }
            else
            {
                return (this.duracion * 0.66f);
            }
        }

        //Sobrecargas
        public override bool Equals(object? obj)
        {
            return obj is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
