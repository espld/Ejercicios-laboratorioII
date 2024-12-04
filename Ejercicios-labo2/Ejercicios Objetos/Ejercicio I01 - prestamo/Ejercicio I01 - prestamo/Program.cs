using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titularCuenta;
            decimal montoCuenta;
            string montoCuentaString;

            //Cuenta cuenta = new Cuenta("Fernandez",180_000);

            //Console.WriteLine(cuenta.GetTitular());
            //Console.WriteLine(cuenta.GetCantidad());
            //Console.WriteLine(cuenta.Mostrar());
            //Console.WriteLine(cuenta.Ingresar(20000));
            //Console.WriteLine("------------");
            //Console.WriteLine(cuenta.Mostrar());
            //Console.WriteLine(cuenta.Retirar(15000));
            //Console.WriteLine("------------");
            //Console.WriteLine(cuenta.Mostrar());
            //Console.WriteLine("------------");
            //Console.WriteLine(cuenta.Retirar(190_000));
            //Console.WriteLine("------------");
            //Console.WriteLine(cuenta.Mostrar());


            Console.WriteLine("****NUEVA CUENTA****");
            Console.WriteLine("Ingrese titular de la cuenta: ");
            titularCuenta = Console.ReadLine();
            Console.WriteLine("Ingrese monto inicial de la cuenta: ");
            montoCuentaString = Console.ReadLine();
            decimal.TryParse(montoCuentaString,out montoCuenta);
            
            Cuenta cuenta = new Cuenta(titularCuenta, montoCuenta);


            
            Console.WriteLine(cuenta.Mostrar());
            Console.WriteLine(cuenta.Ingresar(20000));
            Console.WriteLine("------------");
            Console.WriteLine(cuenta.Mostrar());
            Console.WriteLine(cuenta.Retirar(15000));
            Console.WriteLine("------------");
            Console.WriteLine(cuenta.Mostrar());
            Console.WriteLine("------------");
            Console.WriteLine(cuenta.Retirar(190_000));
            Console.WriteLine("------------");
            Console.WriteLine(cuenta.Mostrar());

            Console.ReadKey();

        }
    }
}
