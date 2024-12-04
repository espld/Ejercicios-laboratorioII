using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(2445, "Chanchi Estevez", 15, 23);
            Jugador j2 = new Jugador(244222, "Cuqui Silvera", 19, 23);
            Jugador j3 = new Jugador(24453, "Cardetti", 5, 10);

            Equipo e = new Equipo(3, "Desamparados");


            Console.WriteLine(e + j1);
            Console.WriteLine(e + j2);
            Console.WriteLine(e + j3);

            Console.WriteLine("\n" + e.MostrarEquipo());
        }
    }
}
