namespace Entidades
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta > 0 && this.tinta <= cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
            else if(tinta < 0)
            {
                this.tinta -= tinta;
            }
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            this.SetTinta(gasto);
            
            if(this.tinta == 0)
            {
                dibujo = "";
            }

            
        }

    }
}
