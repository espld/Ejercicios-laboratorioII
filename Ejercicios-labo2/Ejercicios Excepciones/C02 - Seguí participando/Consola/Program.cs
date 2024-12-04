using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];
            MotoCross moto = new MotoCross((short)10, azar.Next(1, 5).ToString());

            try
            {
                if (formulaUno + moto)
                {

                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine();
                Console.WriteLine("<---------------------------------Excepcion--------------------------------->");
                Console.WriteLine(ex.ToString() + "\n\n");
            }

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());


                if ((formulaUno + autos[i]))
                {
                    Console.WriteLine("Se Agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                }
                else
                {
                    Console.WriteLine("No se agrego ya que la competencia esta completa: {0}", autos[i].MostrarDatos());
                }
            }


            Console.WriteLine();
            Console.WriteLine("<-------------------------------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());

            Console.ReadKey();
        }
    }
}
