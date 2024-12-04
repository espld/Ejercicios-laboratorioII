using System.Runtime.InteropServices;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = int.MinValue;
            int maximo = int.MinValue;
            int acumuladorNumeros = 0;
            float promedio;
            int ban = 0;

            Console.WriteLine("Ingrese 5 números: ");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese número {i + 1}");
                int.TryParse(Console.ReadLine(), out numero);

                if (i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }
                acumuladorNumeros += numero;
            }

            promedio = (float)acumuladorNumeros / 5;


            Console.WriteLine("El valor máximo es: {0}, el valor mínimo es: {1} y el promedio es: {2}", maximo, minimo, promedio);


            Console.ReadKey();



        }
    }
}
