using Biblioteca;

namespace C01___Herencia_deportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo(3, "lbdn");

            Jugador j1 = new Jugador(487754,"Cuqui Silvera",14,10);
            Jugador j2 = new Jugador(412206,"Chanchi Estevez",17,25);
            Jugador j3 = new Jugador(41899,"Alejandro Delorte",9,14);
            Jugador j4 = new Jugador(41299, "Cardetti", 24,18);

            DirectorTecnico dt1 = new DirectorTecnico("Pablo Vicó", new DateTime(1955,11,05));
            DirectorTecnico dt2 = new DirectorTecnico("Sapito Coleoni",new DateTime(1968,08,16));

            //Console.WriteLine(j1.MostrarDatos());
            //Console.WriteLine("");
            //Console.WriteLine("--------");
            //Console.WriteLine(j2.MostrarDatos());
            //Console.WriteLine("");
            //Console.WriteLine("--------");
            //Console.WriteLine(dt1.MostrarDatos());
            //Console.WriteLine(dt2.MostrarDatos());

            Console.WriteLine(e.MostrarJugadores());
            Console.WriteLine(e+j2);
            Console.WriteLine("-------------");
            Console.WriteLine(e+j1);
            Console.WriteLine(e+j3);
            Console.WriteLine(e+j4);
            Console.WriteLine(e.MostrarJugadores());

        }
    }
}
