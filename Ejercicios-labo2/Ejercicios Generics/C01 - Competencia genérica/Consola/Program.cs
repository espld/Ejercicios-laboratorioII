using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Random azar = new Random();
            Competencia<AutoF1> formulaUno = new Competencia<AutoF1>(10, 5, Competencia<AutoF1>.TipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];
            MotoCross moto = new MotoCross((short)10, azar.Next(1, 5).ToString());

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString(), (short)azar.Next(1, 1000));


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
