using Biblioteca;
using static Biblioteca.Jugo;
using static Biblioteca.Producto;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estante estatenteUno = new Estante(4);
            Jugo j1 = new Jugo(112, 25f, EMarcaProducto.Naranju,ESaborJugo.Pasable);


            Console.WriteLine(j1.ToString());
            Console.WriteLine(Estante.ETipoProducto.Jugo);


        }
    }
}
