using System.Runtime.CompilerServices;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 3;
            //int iDos = 5;         

            //Console.WriteLine(i.FizzBuzz());
            //Console.WriteLine(iDos.FizzBuzz());
            //Console.WriteLine(Extension.FizzBuzz(15));

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine(i.FizzBuzz());
            }


        }
      
    }
    public static class Extension
    {
        public static string FizzBuzz(this Int32 entero)
        {

            if (entero % 3 == 0 && entero % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (entero % 3 == 0)
            {
                return "Fizz";
            }
            else if (entero % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return entero.ToString();
            }
        }
    }
}
