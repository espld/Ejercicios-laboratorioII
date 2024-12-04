using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EJ_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Alumno a1 = new Alumno();
            //Alumno a2 = new Alumno();
            //Alumno a3 = new Alumno();

            //a1.nombre = "Lucas";
            //a1.apellido = "Espindola";
            //a1.legajo = 18;
            //a1.Estudiar(6, 7);
            ////a1.CalcularFinal();

            //a2.nombre = "Damian";
            //a2.apellido = "Espindola";
            //a2.legajo = 199;
            //a2.Estudiar(7, 9);
            ////a2.CalcularFinal();


            //a3.nombre = "Pepe";
            //a3.apellido = "Hernandez";
            //a3.legajo = 15547;
            //a3.Estudiar(2, 3);
            ////a3.CalcularFinal();


            //Console.WriteLine(a1.Mostrar());
            //Console.WriteLine("---------");
            //Console.WriteLine(a2.Mostrar());
            //Console.WriteLine("---------");
            //Console.WriteLine(a3.Mostrar());
            //Console.WriteLine("---------");

            //Alumno a1 = new Alumno();
            //byte notaUno;
            //byte notaDos;

            //Console.WriteLine("Ingrese el nombre del alumno: ");
            //a1.nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese el apellido del alumno:" );
            //a1.apellido = Console.ReadLine();
            //Console.WriteLine("Ingrese la primer nota: ");
            //byte.TryParse(Console.ReadLine(),out notaUno);
            //Console.WriteLine("Ingrese la segunda nota: ");
            //byte.TryParse(Console.ReadLine(),out notaDos);
            //a1.Estudiar(notaUno,notaDos);
            //Console.WriteLine(a1.Mostrar());

            //byte notaUno;
            //byte notaDos;

            //Console.WriteLine("Ingresemos alumnos...");
            //for (int i = 0; i < 3; i++)
            //{
            //    Alumno alumno = new Alumno();
            //    Console.WriteLine("Ingrese el nombre del alumno: ");
            //    alumno.nombre = Console.ReadLine();
            //    Console.WriteLine("Ingrese el apellido del alumno:");
            //    alumno.apellido = Console.ReadLine();
            //    Console.WriteLine("Ingrese la primer nota: ");
            //    byte.TryParse(Console.ReadLine(), out notaUno);
            //    Console.WriteLine("Ingrese la segunda nota: ");
            //    byte.TryParse(Console.ReadLine(), out notaDos);
            //    alumno.Estudiar(notaUno, notaDos);
            //    Console.WriteLine(alumno.Mostrar());
            //}

            //Alumno[] alumnos = new Alumno[3];
            //byte notaUno;
            //byte notaDos;

            //Console.WriteLine("Ingresemos alumnos...");
            //for (int i = 0; i < alumnos.Length; i++)
            //{
            //    alumnos[i] = new Alumno();

            //    Console.WriteLine("Ingrese el nombre del alumno: ");
            //    alumnos[i].nombre = Console.ReadLine();
            //    Console.WriteLine("Ingrese el apellido del alumno:");
            //    alumnos[i].apellido = Console.ReadLine();
            //    Console.WriteLine("Ingrese la primer nota: ");
            //    byte.TryParse(Console.ReadLine(), out notaUno);
            //    Console.WriteLine("Ingrese la segunda nota: ");
            //    byte.TryParse(Console.ReadLine(), out notaDos);
            //    alumnos[i].Estudiar(notaUno, notaDos);
              
            //}


            //for (int i = 0; i < alumnos.Length; i++)
            //{
            //    Console.WriteLine(alumnos[i].Mostrar());
            //}


            List<Alumno> alumnos = new List<Alumno>();
            byte notaUno;
            byte notaDos;

            for (int i = 0; i < 3; i++)
            {
                Alumno alumno = new Alumno();

                Console.WriteLine("Nombre");
                alumno.nombre = Console.ReadLine();
                Console.WriteLine("Nota 1: ");
                byte.TryParse(Console.ReadLine(), out notaUno);              
                Console.WriteLine("Nota 2: ");
                byte.TryParse(Console.ReadLine(), out notaDos);
                alumno.Estudiar(notaUno, notaDos);       
                
                alumnos.Add(alumno) ;
            }

            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.Mostrar());
            }

            Console.ReadKey();

        }
    }
}
