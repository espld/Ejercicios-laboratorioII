using System.Text;

namespace Centralita
{
    public class Llamada
    {
        public enum ETipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        //Propiedades
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino;}
        }
        public string NroOrigen
        {
            get { return this.nroOrigen;}
        }

        //Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Numero de Origen: {this.NroOrigen}");
            sb.AppendLine($"Numero de Destino: {this.NroDestino}");

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            return this.OrdenarAscendente((int)llamada1.Duracion, (int)llamada2.Duracion);
        }

        //public int OrdenarDescendente(int a,int b)
        //{
        //    return b - a;
        //}
        public int OrdenarAscendente(int a,int b)
        {
            return a - b;
        }
    }
}
