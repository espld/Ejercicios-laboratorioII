using Biblioteca;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Libro libro = new Libro();

            //libro[0] = "hola";
            //libro[1] = "hola2";
            //libro[1] = "hola3";

            Libro libro = new Libro();

            libro[0] = "Jon I";
            libro[1] = "Daenerys II";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            Console.WriteLine("-----------------");

            libro[1] = "Tyrion III";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(libro[i]);
            }



        }
    }
}
