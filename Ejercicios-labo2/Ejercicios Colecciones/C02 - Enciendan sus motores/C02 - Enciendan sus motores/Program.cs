using Biblioteca;

namespace C02___Enciendan_sus_motores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(14, "Ferrari");
            AutoF1 a2 = new AutoF1(15, "Ferrari");
            AutoF1 a3 = new AutoF1(14, "RedBull");
            AutoF1 a4 = new AutoF1(11, "RedBull");

            Competencia gp = new Competencia(20, 3);


            Console.WriteLine(gp + a1);
            Console.WriteLine(gp+a2);
            Console.WriteLine(gp + a3);
            Console.WriteLine(gp + a4);
            Console.WriteLine("---------");
            Console.WriteLine(gp.MostrarDatos());


            Console.WriteLine(a1.GetCantidadCombustible());
            Console.WriteLine(a1.GetEnCompetencia());
            Console.WriteLine(a1.GetVueltasRestantes());
            Console.WriteLine("-------");
            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine("-------");
            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 == a3);
            






        }
    }
}
