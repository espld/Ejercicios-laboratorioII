using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I05___Aprendete_las_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear una aplicación de consola que permita al usuario ingresar un número entero.

            Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

            Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

            Mostrar en la consola el resultado.
             */

            int numeroAMultiplicar;
            string numeroString;


            Console.WriteLine("Ingrese el número que quiera la tabla de multiplicar: ");
            
            numeroString = Console.ReadLine();

            if(int.TryParse(numeroString, out numeroAMultiplicar))
            {
                Console.WriteLine(TablaMultiplicarDe(numeroAMultiplicar));
            }
            else
            {
                Console.WriteLine("error papi");
            }



            Console.ReadKey();

        }

            static string TablaMultiplicarDe(int numeroAMultiplicar)
            {               
                StringBuilder sb = new StringBuilder();
                Console.WriteLine($"Tabla de multiplicar del número {numeroAMultiplicar}:");

                for (int i = 0; i < 10; i++)
                {
                    sb.AppendLine($"{numeroAMultiplicar} x {i + 1} = {numeroAMultiplicar * (i + 1)}");
                }    
                
                return sb.ToString(); 
            
            }

    }
}
