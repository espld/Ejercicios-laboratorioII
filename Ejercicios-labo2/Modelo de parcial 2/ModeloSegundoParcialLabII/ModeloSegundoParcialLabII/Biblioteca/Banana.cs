using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Banana : Fruta
    {
        protected string paisOrigen;

        public Banana(string color, double peso, string paisOrigen)
            : base(color, peso)
        {
            this.paisOrigen = paisOrigen;
        }

        public string Nombre
        {
            get { return typeof(Banana).Name; }
        }

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
            set
            {
                TieneCarozo = value;
            }
        }

        protected override string FrutasToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Pais de origen: {this.paisOrigen}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.FrutasToString();
        }

    }
}
