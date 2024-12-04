using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Modficar lo que fuere necesario para su implementacion
    public interface IAtendedor
    {
        public Queue<Cliente> FilaClientes { get; set; }
        public string NombrePuestoAtencion { get; }
        public string AtenderClientes();
    }
}
