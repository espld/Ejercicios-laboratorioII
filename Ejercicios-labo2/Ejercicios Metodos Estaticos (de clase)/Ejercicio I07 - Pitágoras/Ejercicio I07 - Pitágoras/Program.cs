using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I07___Pitágoras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

                El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

                Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

                Mostrar el resultado en la consola.
             */

          
            Console.WriteLine("Ingrese el valor del primer cateto: ");
            double catetoUno;
            double.TryParse(Console.ReadLine(), out catetoUno);
            Console.WriteLine("Ingrese el valor del segundo cateto: ");
            double catetoDos;
            double.TryParse(Console.ReadLine(), out catetoDos);

            Console.WriteLine($"El valor de la hipotenusa segun el teorema de pitagoras es: {EncontrarHipotenusaDeTriangulo(catetoUno, catetoDos).ToString("0.00")}");

            
            Console.ReadKey();

        }

        static double EncontrarHipotenusaDeTriangulo(double catetoUno, double catetoDos)
        {
            double hipotenusa;
            double catetoUnoAlCuadrado;
            double catetoDosAlCuadrado;

            catetoUnoAlCuadrado = Math.Pow(catetoUno, 2);
            catetoDosAlCuadrado = Math.Pow(catetoDos, 2);


            hipotenusa = Math.Sqrt(catetoUnoAlCuadrado +  catetoDosAlCuadrado);

            return hipotenusa;
        }



    }
}
