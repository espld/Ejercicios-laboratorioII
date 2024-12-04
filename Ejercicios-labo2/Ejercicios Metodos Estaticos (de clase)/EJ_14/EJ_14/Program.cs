using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
                cálculo del área que corresponda:
                a. double CalcularCuadrado(double)
                b. double CalcularTriangulo(double, double)
                c. double CalcularCirculo(double)
                El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/

            Console.WriteLine("Ingrese lado del cuadrado: ");
            int ladoCuadrado = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area del cuadrado: {CalculadoraDeArea.CalcularCuadrado(ladoCuadrado)}");
            Console.WriteLine("************");

            Console.WriteLine("Ingrese base del triangulo: ");
            int baseTriangulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura del triangulo: ");
            int alturaTriangulo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area del triangulo: {CalculadoraDeArea.CalcularTriangulo(baseTriangulo,alturaTriangulo)}");
            Console.WriteLine("************");

            Console.WriteLine("Ingrese radio del circulo: ");
            int radioCirculo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area del circulo: {CalculadoraDeArea.CalcularCirculo(radioCirculo).ToString("0.00")}");


            Console.ReadKey();
        }
    }
}
