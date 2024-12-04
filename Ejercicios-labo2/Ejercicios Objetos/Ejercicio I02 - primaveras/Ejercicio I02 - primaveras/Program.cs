using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02___primaveras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona("Lucas",1995,17_133_113);
            Persona p2 = new Persona("pepitopx",2006,17_133_1483);

            Console.WriteLine(p1.Mostrar());
            Console.WriteLine(p2.Mostrar());

            Console.ReadKey();


        }
    }
}
