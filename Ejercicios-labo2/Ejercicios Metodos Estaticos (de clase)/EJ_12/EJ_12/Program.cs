using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
                un mensaje &quot;¿Continuar? (S/N)&quot;.
                En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
                opciones.
                El método devolverá un valor de tipo booleano, TRUE si se ingresó una &#39;S&#39; y FALSE si se ingresó
                cualquier otro valor. */


            int n;
            string numeroString;
            int acumNumeros = 0;
            int i = 0;

            Console.WriteLine("Ingrese numero a sumar: ");
            numeroString = Console.ReadLine();
            while(!int.TryParse(numeroString, out n))
            {
                Console.WriteLine("Error. Reingrese numero");
                numeroString = Console.ReadLine();
            }

            acumNumeros += n;
            Console.WriteLine("Continuar? s/n");
            char respuesta = Console.ReadKey().KeyChar;
            ValidarRespuesta.ValidaS_N(respuesta);

            while (ValidarRespuesta.ValidaS_N(respuesta) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese numero a sumar: ");
                int.TryParse(Console.ReadLine(), out n);
                acumNumeros += n;

                Console.WriteLine("Continuar? s/n");
                respuesta = Console.ReadKey().KeyChar;
                ValidarRespuesta.ValidaS_N(respuesta);

                i++;
            }



            Console.WriteLine("");
            Console.WriteLine($"La suma es: {acumNumeros}");







            Console.ReadKey();

        }
    }
}
