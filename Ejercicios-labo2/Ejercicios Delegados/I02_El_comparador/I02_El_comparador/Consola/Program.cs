using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.Environment;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2


            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");

            Comparar(primerTexto, segundoTexto, (x, y) => x.Length - y.Length);

            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            //split separa un string en un array de strings en base a un caracter en especifico, en este caso un espacio
            Comparar(primerTexto, segundoTexto, (x, y) => x.Split(' ').Length - y.Split(' ').Length);

            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");

            Comparar(primerTexto, segundoTexto, (x, y) => ContarVocales(x) - ContarVocales(y));

            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");

            Comparar(primerTexto, segundoTexto, (x, y) => ContarSignosPuntuacion(x) - ContarSignosPuntuacion(y));

        }
        public static void Comparar(string textoUno, string textoDos, Func<string, string, int> criterio)
        //puedo usar func o el delegado creado arriba
        {
            if (criterio(textoUno, textoDos) > 0)
            {
                Console.WriteLine("El primer texto es MAYOR que el segundo");
            }
            else if (criterio(textoUno, textoDos) < 0)
            {
                Console.WriteLine("El primer texto es MENOR que el segundo");
            }
            else
            {
                Console.WriteLine("El primer texto es IGUAL que el segundo");
            }
        }

        //OTRA MANERA CON EL DELEGADO PROPIO
        //public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        //public static void Comparar(string textoUno, string textoDos, DelegadoComparacion delegadoComparacion)
        ////puedo usar func o el delegado creado arriba
        //{
        //    if (delegadoComparacion(textoUno, textoDos) > 0)
        //    {
        //        Console.WriteLine("El primer texto es MAYOR que el segundo");
        //    }
        //    else if (delegadoComparacion(textoUno, textoDos) < 0)
        //    {
        //        Console.WriteLine("El primer texto es MENOR que el segundo");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El primer texto es IGUAL que el segundo");
        //    }
        //}

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }
    }
}
