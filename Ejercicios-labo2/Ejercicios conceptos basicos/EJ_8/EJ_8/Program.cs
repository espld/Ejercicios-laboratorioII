using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
            trabajadas en el mes de N empleados de una fábrica.

            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
            valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
            descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            Nota: Utilizar estructuras repetitivas y selectivas.*/


            Console.WriteLine("Total empleados a ingresar: ");
            int cantidadEmpleados;
            int.TryParse(Console.ReadLine(), out cantidadEmpleados);

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Antiguedad: ");
                int antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de horas trabajadas en el mes: ");
                int cantidadHorasTrabajadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor de Hora: ");
                int valorHora = int.Parse(Console.ReadLine());

                int totalHoras = valorHora * cantidadHorasTrabajadas;
                int cantidadAños = antiguedad * 150;
                
                

                int importebruto = totalHoras + cantidadAños;
                int descuento = (importebruto * 13) / 100;
                int importeNeto = importebruto - descuento;

                Console.WriteLine("-------------");

                Console.WriteLine($"Nombre: {nombre}, antiguedad: {antiguedad},valor hora: {valorHora},total bruto: {importebruto}, descuentos: {descuento}%,total neto: {importeNeto}");
            }

            Console.ReadKey();


        }
    }
}
