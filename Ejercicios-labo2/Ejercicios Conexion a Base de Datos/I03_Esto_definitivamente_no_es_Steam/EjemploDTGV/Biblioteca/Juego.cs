namespace Biblioteca
{
    public class Juego
    {
        private string nombre;
        private string genero;
        private double precio;
        private int codigoUsuario;
        private int codigoJuego;

        public Juego(string nombre, double precio,string genero,int codigoJuego,int codigoUsuario)
            :this(nombre,precio,genero,codigoUsuario)
        {          
            this.codigoJuego = codigoJuego;
        }
        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }
        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public int CodigoUsuario
        {
            get { return this.codigoUsuario; }
            set { this.codigoUsuario = value; }
        }
        public int CodigoJuego
        {
            get { return this.codigoJuego; }
            set { this.codigoJuego = value; }
        }

    }
}
