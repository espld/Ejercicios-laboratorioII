using System.Runtime.CompilerServices;

namespace Biblioteca
{
    public class PuestoAtencion
    {
       
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)           
        {
            this.puesto = puesto;
        }

        //Prop
        public int NumeroActual
        {
            get 
            {
                //numeroActual += 1;
                return ++numeroActual;
            }
        }

        //Metodos
        public bool Atender(Cliente cliente)
        {
            if (cliente is not null)
            { 
                Thread.Sleep(3000);
                Console.WriteLine($"{cliente.Nombre} Atendido.");
                return true;
            }
            return false;
        }


    }
}
