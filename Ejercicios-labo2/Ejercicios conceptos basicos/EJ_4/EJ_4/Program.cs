using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EJ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contPerfectos = 0;
            int acumDivisibles = 0;

            Console.WriteLine("Los primeros 4 números perfectos son: ");
            int i = 1;

            while (contPerfectos != 4)
            {
                acumDivisibles = 0;

                for (int x = 1; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        acumDivisibles += x;
                    }
                }
                if (acumDivisibles == i)
                {
                    Console.WriteLine(i);
                    contPerfectos++;                  
                }

                i++;
            }

         

           

            Console.ReadKey();

        }
    }
}
