namespace I01___Números_locos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();

            int[] numeros = new int[20];
            List<int> list = new List<int>();
                      

            for (int i = 0; i < numeros.Length; i++)
            {

                numeros[i] = random.Next(-100,100);

            }
            Console.WriteLine("Orden Original");
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < numeros.Length ; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Orden Decreciente de los números positivos");
            Array.Sort(numeros,OrdenDescendente);
            foreach (var item in numeros)
            {
                if(item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Orden Creciente de los negativos");
            Array.Sort(numeros, OrdenAscendente);
            foreach (var item in numeros)
            {
                if(item < 0)
                {
                    Console.WriteLine(item);
                }
            }

        }

        public static int OrdenAscendente(int a, int b)
        {
            return a - b;
        }
        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }


    }
}
