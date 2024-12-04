namespace Biblioteca
{
    public class Boligrafo: IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        //Propiedades
        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }
        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        //Metodos
        public EscrituraWrapper Escribir(string texto)
        {           
            this.tinta -= (float)texto.Length * 0.3f;

            return new EscrituraWrapper(texto, ConsoleColor.Gray);
        }
        public bool Recargar(int unidades)
        {        
                this.UnidadesDeEscritura += unidades;
                return true;
        }
        public override string ToString()
        {
            return $"Boligrafo con color de escritura {this.Color} y su nivel es {this.UnidadesDeEscritura}";
        }

    }
}
