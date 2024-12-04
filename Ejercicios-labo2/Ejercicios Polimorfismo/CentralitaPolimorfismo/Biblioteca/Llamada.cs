using System.Text;

namespace Biblioteca
{
    public abstract class Llamada
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
        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        //Metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Numero de Origen: {this.NroOrigen}");
            sb.AppendLine($"Numero de Destino: {this.NroDestino}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return OrdenarAscendente((int)llamada1.Duracion, (int)llamada2.Duracion);
        }

        //public int OrdenarDescendente(int a,int b)
        //{
        //    return b - a;
        //}
        private static int OrdenarAscendente(int a, int b)
        {
            return a - b;
        }

        //Sobrecargas
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            
            return !(l1 == l2);
        }

    }
}
