using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudiante e1 = new Estudiante("Lucas","Espindola","14439");
            Estudiante e2 = new Estudiante("Lucas","Espi","14430059");
            Estudiante e3 = new Estudiante("Lucas","Espin","14439777");

            e1.NotaPrimerParcial = 5;
            e1.NotaSegundoParcial = 7;
            e2.NotaPrimerParcial = 8;
            e2.NotaSegundoParcial = 9;
            e3.NotaPrimerParcial = 3;
            e3.NotaSegundoParcial = 2;

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine("---------------");
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine("---------------");
            Console.WriteLine(e3.Mostrar());

            Console.ReadKey();

        }
    }
}
