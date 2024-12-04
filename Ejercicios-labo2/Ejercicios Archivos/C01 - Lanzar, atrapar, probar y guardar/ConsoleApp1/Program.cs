using Biblioteca;
using IO;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            string nombreArchivo = fecha.ToString("yyyyMMdd-hhmm") + ".txt";

            try
            {
                OtraClase obj = new OtraClase();
                obj.MetodoInstancia();
                
            }
            catch (Exception ex)
            {
                ArchivoTexto.Guardar(nombreArchivo, ex.Message);
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    ArchivoTexto.Guardar(nombreArchivo, ex.Message);
                }
            }

            Console.WriteLine(ArchivoTexto.Leer(nombreArchivo));
            Console.ReadKey();
        }
    }
}
