using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
//10.PuestoPrioritario:
//  a.Implementa IAtendedor.
//  b.Por defecto un puesto prioritario será de MAX_UNIDADES con 15 propductos.
//  c.La propiedad NombrePuestoAtencion retornara "Puesto de atencion Prioritario de tipo [tipo]”
//  d.La sobrecarga del operador  ==  comparara un PuestoPrioritario con un cliente para determinar si puede ser atendido por dicho puesto.
//      Se retornará True si puesto es de tipo ANT_ESPECIAL y el cliente requiere prioridad, o si el tipo es MAX_UNIDADES y la cantidad de productos del cliente es menor a los permitidos en el puesto de atención.
//  e.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.
//      De lo contrario retira el primer cliente de la Queue y verifica si este puede ser atendido de forma prioritaria.
//      En caso afirmativo retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.
//      En caso negativo se lanzará una excepción ClienteNoAtendidoException. 
    
    public class PuestoPrioritario: IAtendedor
    {
        public enum ETipo
        {
           MAX_UNIDADES,
           ATN_ESpecial
        }
        private int cantProductos;
        private Queue<Cliente> filaClientes;
        private ETipo tipo;
      
        public PuestoPrioritario(ETipo tipo,int cantProductos)
        {
            this.tipo = tipo;
            this.cantProductos = cantProductos;
            this.filaClientes = new Queue<Cliente>();
        }
        public PuestoPrioritario():this(ETipo.MAX_UNIDADES,15)
        {
        }
        //Propiedades
        public Queue<Cliente> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
            set
            {
                this.filaClientes = value;
            }
        }

        public string NombrePuestoAtencion
        {
            get { return $"Puesto de atencion Prioritario de tipo {this.Tipo}"; }
        }
        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        //Metodos
        public string AtenderClientes()
        {
            string retorno = "";

           if(this.FilaClientes.Count < 1)
            {
                retorno =  "Sin clientes";
            }
            else
            {
                Cliente c = this.FilaClientes.Dequeue();
                if(this == c)
                {
                    retorno =  $"Cliente atentido en {this.NombrePuestoAtencion}";
                }
                else
                {
                    throw new ClienteNoAtendidoException();
                }
            }

            return retorno;
        }
        //Sobrecargas
        public static bool operator ==(PuestoPrioritario puesto, Cliente cliente)
        {
            if(puesto.tipo == ETipo.ATN_ESpecial && cliente.Prioridad == true || puesto.Tipo == ETipo.MAX_UNIDADES && cliente.CantProductos <= 15)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(PuestoPrioritario puesto, Cliente cliente)
        {
            return !(puesto == cliente);
        }

    }
}
