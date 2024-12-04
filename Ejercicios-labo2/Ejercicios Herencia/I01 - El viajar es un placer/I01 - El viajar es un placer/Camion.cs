using System.Text;

namespace I01___El_viajar_es_un_placer
{
    public class Camion: VehiculoTerrestre
    {
        /*
         cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
         */

        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadPuertas,short cantidadRuedas,Colores color,short cantidadMarchas,int pesoCarga) 
            :base(cantidadPuertas,cantidadRuedas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-----CAMION-----");
            sb.AppendLine($"Puertas: {base.CantidadPuertas}");
            sb.AppendLine($"Ruedas: {base.CantidadRuedas}");
            sb.AppendLine($"Color: {base.Color}");
            sb.AppendLine($"Marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Peso carga: {this.pesoCarga}");

            return sb.ToString();
        }



        //public Camion(short cantidadRuedas, short cantidadPuertas, string color, short cantidadMarchas, int pesoCarga)
        //{
        //    this.cantidadRuedas = cantidadRuedas;
        //    this.cantidadPuertas = cantidadPuertas;
        //    this.color = color;
        //    this.cantidadMarchas = cantidadMarchas;
        //    this.pesoCarga = pesoCarga;
        //}



    }
}
