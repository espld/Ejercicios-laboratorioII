using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la
                siguiente firma: bool Validar(int valor, int min, int max):
                a. valor: dato a validar
                b. min y max: rango en el cual deberá estar la variable valor.
                Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
                anteriormente que estén dentro del rango -100 y 100.
                Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
                Nota: Utilizar variables escalares, NO utilizar vectores.*/

            Console.WriteLine("Ingrese 10 numeros...");

            int numeroMenor = int.MinValue;
            int numeroMayor = int.MaxValue;
            int acumNumeros = 0;
            int contNumerosValidos = 0;
            int flagPrimerNumero = 0;
            int n;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Numero {i + 1}: ");
                int.TryParse(Console.ReadLine(), out n);

                if (Validacion.Validar(n, -100, 100))
                {
                    if (flagPrimerNumero == 0)
                    {
                        numeroMenor = n;
                        numeroMayor = n;
                        flagPrimerNumero = 1;
                    }
                    else
                    {
                        if (n > numeroMayor)
                        {
                            numeroMayor = n;
                        }
                        else
                        {
                            if (n < numeroMenor)
                            {
                                numeroMenor = n;
                            }
                        }
                    }
                    acumNumeros += n;
                    contNumerosValidos++;

                }
                else
                {
                    Console.WriteLine("No esta en el rango, no se va a tener en cuenta");
                }
            }

            float promedio = (float)acumNumeros / contNumerosValidos;

            Console.WriteLine($"Valor Máximo: {numeroMayor}, Valor mínimo: {numeroMenor}, Promedio: {promedio.ToString("0.00")}");
            //Console.WriteLine("Valor maximo {0}, Valor mínimo {1}, Promedio {2}",numeroMayor,numeroMenor,promedio.ToString("0.00"));

            Console.ReadKey();

        }
    }
}
