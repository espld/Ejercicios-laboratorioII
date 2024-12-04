using static System.Net.Mime.MediaTypeNames;

namespace EJ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int contPrimos = 0;

            Console.WriteLine("Ingrese numero: ");
            int.TryParse(Console.ReadLine(), out n);

            for (int x = 0; x <= n; x++)
            {
                int cont = 0;
                for (int y = 1; y <= x; y++)
                {
                    
                    if (x % y == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine("\n" + x);
                    
                }

            }

            //Console.WriteLine("cantidad de primos es {0}", contPrimos);


            Console.ReadKey();

        }
    }
}
