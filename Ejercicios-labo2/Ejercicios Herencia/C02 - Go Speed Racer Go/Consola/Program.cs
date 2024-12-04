using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoDeCarrera vc1 = new VehiculoDeCarrera(22, "RedBullRacing");
            VehiculoDeCarrera vc2 = new VehiculoDeCarrera(22, "RedBullRacing");
            AutoF1 auto1 = new AutoF1(14, "Ferrari", 15);
            AutoF1 auto2 = new AutoF1(14, "Ferrari", 15);

            Console.WriteLine($"Iguales vc? {vc1 == vc2}");
            Console.WriteLine($"Iguales autosf1? {auto1 == auto2}");

            Console.WriteLine(auto1.MostrarDatos());
        }
    }
}
