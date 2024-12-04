using I01___El_viajar_es_un_placer;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Automovil auto = new Automovil(5, 4,Colores.Blanco, 5, 5);
            Camion camion = new Camion(2,16,Colores.Negro,5,180);
            Moto moto = new Moto(0, 2, Colores.Rojo, 250);

            Console.WriteLine(auto.Mostrar());          
            Console.WriteLine(camion.Mostrar());           
            Console.WriteLine(moto.Mostrar()); 
        }
    }
}
