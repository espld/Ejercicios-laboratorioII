using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01___Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

            En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
             */

            Console.WriteLine(CalcularFactorial(5));


            Console.ReadKey();
        }

        static int CalcularFactorial(int n)
        {

           

            for (int i = n - 1; i > 0; i--)
            {

                n *= i;

            }

            return n;

        }
    }

    

}
