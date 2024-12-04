using System.Drawing;
using static Consola.Program;
using static Consola.Program.Sobrescrito;

namespace Consola
{
    internal class Program
    {

        public abstract class Sobrescrito

        {
            //Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con visibilidad protected.

            protected string miAtributo;

            //Generar un constructor de instancia que inicialice miAtributo con el valor "Probar abstractos".
            protected Sobrescrito()
            {
                this.miAtributo = "Probar abstractos.";
            }
            /*Agregará propiedad abstracta MiPropiedad de sólo lectura.
            Una vez implementada, retornará el valor de miAtributo.*/
            public abstract string MiPropiedad
            {
                get;
            }
            /*Crear un método abstracto MiMetodo que retorne un string. 
            Una vez implementada, retornará el valor de MiPropiedad.*/

            public abstract string MiMetodo();

            public override string ToString()
            {
                return "¡Este es mi método ToString sobrescrito!";
            }
            public override bool Equals(object? obj)
            {
                //return obj.GetType() == typeof(Sobrescrito) ;
                return obj is Sobrescrito;
            }
            public override int GetHashCode()
            {
                return 1142510181;
            }

            public class SobreSobreEscrito : Sobrescrito
            {

                public SobreSobreEscrito()
                    : base()
                {

                }

                public override  string MiPropiedad
                {
                    get
                    {
                        return base.miAtributo;
                    }
                }

                public override string MiMetodo()
                {
                    return this.MiPropiedad;
                }
            }


        }



        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito objetoSobrescrito = new SobreSobreEscrito();
            Sobrescrito objetoSobrescrito2 = new SobreSobreEscrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));
            Console.WriteLine(objetoSobrescrito.Equals(objetoSobrescrito2));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());
            Console.WriteLine(objetoSobrescrito.MiPropiedad);
            Console.WriteLine(objetoSobrescrito.MiMetodo());

            Console.ReadKey();


        }
    }
}
