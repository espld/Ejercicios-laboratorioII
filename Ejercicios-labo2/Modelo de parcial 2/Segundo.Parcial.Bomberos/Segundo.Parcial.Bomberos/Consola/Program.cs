using Entidades;
using System.Diagnostics.Contracts;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bombero bombero = new Bombero("Pepe");
            Salida salida = new Salida();
            LogDAO logDAO = new LogDAO();

            try
            {
                //bombero.Salidas.Add(salida);
                //bombero.Guardar(bombero);

                //Bombero bom = bombero.Leer();
                //foreach (var item in bom.Salidas)
                //{
                //    Console.WriteLine(item.FechaInicio);
                //    Console.WriteLine(item.FechaFin);
                //}

                //string asd = "holaaa";
                ((IArchivo<string>)bombero).Guardar("11 puntos pibeee");
                //logDAO.InsertarLog(asd);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
