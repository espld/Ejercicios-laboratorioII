namespace Biblioteca
{
    public class JuegoDto
    {
        //MODELO IDENTICO A LA BASE DE DATOS, PORQUE DESPUES HAY QUE MAPEARLO.
        //REPRESENTACION EN CODIGO DE LAS TABLAS

        //DTO DATA TRANSFER OBJECT
        //OBJETOS QUE SE USAN PARA PASAR INFORMACION. DE LA BASE DE DATOS LO PASO A OBJETOS.
        //OBJETOS QUE REPRESENTAN A LA BASE DE DATOS

        private string nombre;
        private double precio;
        private string genero;
        private int codigoJuego;
        private int codigoUsuario;

        public JuegoDto(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario;
        }
        public JuegoDto(string nombre, double precio, string genero,int codigoJuego, int codigoUsuario)
            :this(nombre,precio, genero,codigoUsuario)
        {
            this.codigoJuego = codigoJuego;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Genero { get => genero; set => genero = value; }
        public int CodigoJuego { get => codigoJuego; set => codigoJuego = value; }
        public int CodigoUsuario { get => codigoUsuario; set => codigoUsuario = value; }
    }
}
