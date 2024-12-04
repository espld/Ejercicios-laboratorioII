using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01___autonavegacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             De una empresa de transporte de cargas se quiere guardar el nombre de los conductores 
            y los kilómetros que conducen cada día de la semana.

                Para guardar esta información, la empresa de transporte tendrá un array de conductores.

                De cada conductor se tendrá la siguiente información:

                Nombre del conductor.
                Kilometros recorridos por cada día de la semana. Por ejemplo:
                Día 1: 200
                Día 2: 599
                Día 3: 899
                Día 4: 0 (tiene franco)
                Día 5: 256
                Día 6: 0
                Día 7: 0
             */

            EmpresaTransporte e1 = new EmpresaTransporte("CONDOR VIAJES");

            Conductor c1 = new Conductor("Lucas", "Espindola");
            Conductor c2 = new Conductor("Pepe", "Rodriguez");
            e1.agregarConductor(c1);
            e1.agregarConductor(c2);

            e1.AgregarKmRecorridosPorDia(c1,150,468,422,84,0,0,0);
            e1.AcumularKmRecorridos(c1);

            e1.AgregarKmRecorridosPorDia(c2,400,50,674,0,0,49,0);
            e1.AcumularKmRecorridos(c2);


            Console.WriteLine(e1.MostrarDatosEmpresa());
            Console.WriteLine(e1.ConductorConMayorKmPorSemana(c1, c2));
            Console.WriteLine(e1.ConductorConMasKmPorDia(c1,c2,6)); //esta mal, ver que onda



            Console.ReadKey();
        }
    }
}
