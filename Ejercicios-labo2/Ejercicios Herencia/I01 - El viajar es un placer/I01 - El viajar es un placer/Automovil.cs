using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01___El_viajar_es_un_placer
{
    public class Automovil: VehiculoTerrestre
    {
        /*
         cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int.
         */


        private short cantidadMarchas;
        private int cantidadPasajeros;

       public Automovil(short cantidadPuertas, short cantidadRuedas,Colores color,short cantidadMarchas,int cantidadPasajeros)
            :base(cantidadPuertas,cantidadRuedas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-----AUTO-----");
            sb.AppendLine($"Puertas: {base.CantidadPuertas}");
            sb.AppendLine($"Ruedas: {base.CantidadRuedas}");
            sb.AppendLine($"Color: {base.Color}");
            sb.AppendLine($"Marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Pasajeros: {this.cantidadPasajeros}");

            return sb.ToString();
        }

        //public Automovil(short cantidadRuedas, short cantidadPuertas, string color, short cantidadMarchas, int cantidadPasajeros)
        //{
        //    this.cantidadRuedas = cantidadRuedas;
        //    this.cantidadPuertas = cantidadPuertas;
        //    this.color = color;
        //    this.cantidadMarchas = cantidadMarchas;
        //    this.cantidadPasajeros = cantidadPasajeros;
        //}
    }
}
