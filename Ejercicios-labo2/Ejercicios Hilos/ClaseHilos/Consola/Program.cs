using System;

namespace Consola
{
    internal class Program
    {
        private static DateTime time;
        private static Random random;

        static void Main(string[] args)
        {
            random = new Random();
            time = DateTime.Now;

            //Task.Run recibe un action.
            Task hilo = Task.Run(EjecutarSincronico); //creo un hilo para ejecutar EjecutarSincronico
            Task hilo2 = Task.Run(EjecutarEnParalelo);//Creo otro hilo para ejecutar EjecutarEnParalelo.

            Task.WaitAll(hilo, hilo2); // espero que terminen todos los hilos para continuar.

            Console.WriteLine("FINALIZARON TODOS LOS HILOS");
        }

        public static void EjecutarEnParalelo()
        {
            Queue<Action> tareas = new Queue<Action>();
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-A"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-B"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-C"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-D"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-E"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-F"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-G"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-H"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-I"));

            foreach (Action tarea in tareas)
            {
                Task.Run(tarea); //creo subhilos por cada tarea para el hilo que ejecuta EjecutarEnParalelo();
            }
        }

        public static void EjecutarSincronico()
        {
            Queue<Action> tareas = new Queue<Action>(); 
            //queue de tipo delegado Action, que no recibe parametros y no devuelve nada

            //se hace trampa y se le pasa una funcion anonima que no recibe nada y no retorna nada que llama
            //al metodo EjecutarTareaSync.
            tareas.Enqueue(() => EjecutarTareaSync("SINC-A"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-B"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-C"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-D"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-E"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-F"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-G"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-H"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-I")); 

            foreach (Action tarea in tareas)
            {
                tarea(); //estoy llamando al delegado que hace refencia a Ejecutar tarea sync
            }
        }

        public static void EjecutarTarea(string codigo)
        {
            int tiempo = random.Next(1000, 5000); // calcula tiempo random.
            Thread.Sleep(tiempo); // detiene el programa por el tiempo random.
            Console.WriteLine($"{DateTime.Now:T} - Tarea {codigo} completada en {tiempo} ms.");
        }

        public static void EjecutarTareaSync(string codigo)
        {
            int tiempo = random.Next(1000, 5000); 
            Thread.Sleep(tiempo); 
            Console.WriteLine($"{DateTime.Now:T} - Tarea {codigo} completada en {(DateTime.Now - time).TotalSeconds} ms.");
        }


    }
}
