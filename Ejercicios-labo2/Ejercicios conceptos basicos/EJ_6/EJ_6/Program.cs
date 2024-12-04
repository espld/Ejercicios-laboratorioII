using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* Escribir un programa que determine si un año es bisiesto.
                Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
                también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
                Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
                Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/


            Console.WriteLine("Ingrese año de inicio: ");
            int anioInicio;
            int.TryParse(Console.ReadLine(), out anioInicio);
            Console.WriteLine("Ingrese año  de fin: ");
            int anioFin;
            int.TryParse(Console.ReadLine(), out anioFin);

            for (int i = anioInicio; i <= anioFin; i++)
            {

                if((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine("--------");
                    Console.WriteLine(i);
                }
            }


            Console.ReadKey();
        }
    }
}
