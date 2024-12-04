using ArchivosUno;
using Serializacion_01;
using Serializacion_02;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Archivo.Escribir("Laboratorio");
                //Console.WriteLine(Archivo.Leer());
                ArchivoDos.Escribir();
                //Console.WriteLine(ArchivoDos.Leer());

                //Personaje pj1 = new Personaje("Pepex",5);

                //Serializadora.Escribir(pj1);
                //Console.WriteLine(Serializadora.Leer()); 

                //Mascota masc1 = new Mascota("jaja", "alguna", 6, true, true);

                //SerializadoraJson.Escribir(masc1);

                //Console.WriteLine(SerializadoraJson.Leer()); 

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }
        }
    }
}
