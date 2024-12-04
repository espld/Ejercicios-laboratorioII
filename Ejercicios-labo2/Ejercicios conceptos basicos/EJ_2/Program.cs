namespace EJ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
            Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
             */

            string numeroIngresado;
            bool estado;
            int valorParseado;

            Console.WriteLine("Ingrese un número mayor a 0");

            numeroIngresado = Console.ReadLine();

            estado = int.TryParse(numeroIngresado, out valorParseado);

            while(!estado || valorParseado < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numeroIngresado = Console.ReadLine();
                estado = int.TryParse(numeroIngresado, out valorParseado);
            }
            Console.WriteLine($"El cuadrado de {valorParseado} es {Math.Pow(valorParseado,2)}");
            Console.WriteLine($"El cubo de {valorParseado} es {Math.Pow(valorParseado,3)}");





            Console.ReadKey();
        }
    }
}
