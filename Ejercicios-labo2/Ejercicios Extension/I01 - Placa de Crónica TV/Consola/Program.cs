using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(MiExtension.ObtenerPlacaCronica(DateTime.Now, EEstaciones.Verano));
            //Console.WriteLine("--------------------------");
            //Console.WriteLine(MiExtension.ObtenerPlacaCronica(DateTime.Now, EEstaciones.Otonio));
            //Console.WriteLine("--------------------------");
            //Console.WriteLine(MiExtension.ObtenerPlacaCronica(DateTime.Now, EEstaciones.Invierno));
            //Console.WriteLine("--------------------------");
            //Console.WriteLine(MiExtension.ObtenerPlacaCronica(DateTime.Now, EEstaciones.Primavera)); 


            DateTime fechaActual = DateTime.Now;

            foreach (EEstaciones estacion in Enum.GetValues(typeof(EEstaciones)))
            {
                string resultado = fechaActual.ObtenerPlacaCronicaTV(estacion);
                Console.WriteLine(resultado);
            }


        }
    }
}
