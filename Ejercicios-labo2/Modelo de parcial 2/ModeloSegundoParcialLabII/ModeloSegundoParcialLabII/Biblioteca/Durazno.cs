using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Durazno : Fruta
    {
        private int cantPelusa;

        public Durazno(string color,double peso, int cantPelusa)
            :base(color,peso)
        {
            this.cantPelusa = cantPelusa;
        }

        public string Nombre
        {
            get { return typeof(Durazno).Name; }
        }
        public override bool TieneCarozo 
        { 
            get { return true; }
            set { TieneCarozo = value; } 
        }

        protected override string FrutasToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutasToString());
            sb.AppendLine($"Cant pelusa {this.cantPelusa}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return FrutasToString();
        }


    }
}
