using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A02___La_veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mascota m1 = new Mascota("Perro", "pepitox", new DateTime(2022,07,18));
            Mascota m2 = new Mascota("Gato", "pepa", DateTime.Now);
            m2.Vacunacion = "Triple Felina";

            Mascota m3 = new Mascota("Perro", "samuel", DateTime.Now);
            m3.Vacunacion = "Antirrábica";

            Mascota m4 = new Mascota("Gato", "tarantino", DateTime.Now);
            

            
            Clientes c1 = new Clientes("Lucas", "Espindola", "144332");
            c1.AgregarMascota(m1);

            Clientes c2 = new Clientes("Hector", "Fernandez", "61644");
            c2.AgregarMascota(m2);

            Clientes c3 = new Clientes("Juan", "Hernandez", "33264");
            c3.AgregarMascota(m3);
            c3.AgregarMascota(m4);



            Console.WriteLine(c1.MostrarDatosCliente());
            Console.WriteLine(c2.MostrarDatosCliente());
            Console.WriteLine(c3.MostrarDatosCliente());



            //Console.WriteLine(m1.Especie);
            //Console.WriteLine(m1.Nombre);
            //Console.WriteLine(m1.Vacunacion);

            //Console.WriteLine(m1.MostrarDatosMascota()); 


            Console.ReadKey();
        }

    }
}
