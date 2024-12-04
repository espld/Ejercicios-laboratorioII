using System.Collections.Immutable;

namespace I02___Números_locos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();

            List<int> listaEnteros = new List<int>();
            Stack<int> stackEnteros = new Stack<int>();
            Queue<int> queueEnteros = new Queue<int>();


            for (int i = 0; i < 5; i++)
            {
                listaEnteros.Add(random.Next(-100, 100));
                stackEnteros.Push(random.Next(-100, 100));
                queueEnteros.Enqueue(random.Next(-100, 100));
            }

            foreach (var item in listaEnteros)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("");
            //for (int i = 0; i < listaEnteros.Count; i++)
            //{
            //    Console.WriteLine(listaEnteros[i]);
            //}
            Console.WriteLine("\nSTACK");
            foreach (var item in stackEnteros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nQUEUE");
            foreach (var item in queueEnteros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nOrden Ascendente");
            listaEnteros.Sort(OrdenAscendente);
            foreach (var item in listaEnteros)
            {
                Console.WriteLine(item);
            }
            stackEnteros.
        }

        public static int OrdenAscendente(int a,int b)
        {
            return a - b;
        }
        public static int OrdenDescente(int a,int b)
        {
            return b - a;
        }
    }
}
