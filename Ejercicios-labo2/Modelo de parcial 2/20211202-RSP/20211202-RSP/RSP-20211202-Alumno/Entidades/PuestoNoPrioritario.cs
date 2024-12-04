using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //11.	PuestoNoPrioritario:
    //  a.Implementa IAtendedor.
    //  b.La propiedad NombrePuestoAtencion retornara "Puesto de atención No Prioritario”
    //  c.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.
    //      De lo contrario retira el primer cliente de la Queue y retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.

    public class PuestoNoPrioritario: IAtendedor
    {
        private Queue<Cliente> filaClientes;

        public PuestoNoPrioritario()
        {
            this.filaClientes = new Queue<Cliente>();
        }

        public Queue<Cliente> FilaClientes
        {
            get { return this.filaClientes;}
            set {  this.filaClientes = value;}
        }

        public string NombrePuestoAtencion
        {
            get { return "Puesto de Atencion No Prioritario"; }
        }

        public string AtenderClientes()
        {
            string retorno = string.Empty;

            if(this.FilaClientes.Count < 1)
            {
                retorno = "Sin clientes.";
            }
            else
            {
                this.FilaClientes.Dequeue();
                retorno = $"Cliente Atendido en {this.NombrePuestoAtencion}";
            }
            return retorno;
        }
    }
}
