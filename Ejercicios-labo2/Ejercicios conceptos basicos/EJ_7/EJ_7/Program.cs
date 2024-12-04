using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
                calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
                con DateTime.Now).
                Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/


            Console.WriteLine("Ingrese año de nacimiento: ");
            int a;
            int.TryParse(Console.ReadLine(), out a);

            int aniosVividos;
            int diasVividos;

            DateTime dateTime = DateTime.Now;

            aniosVividos = dateTime.Year - a;
            diasVividos = (aniosVividos * 365) / 1;

            //1 año = 365 dias
            //28 años = x



            //Console.WriteLine($"Años vividos: {aniosVividos}");
            Console.WriteLine($"Dias vividos: {diasVividos}");

          

            Console.ReadKey();




            


        }
    }
}
