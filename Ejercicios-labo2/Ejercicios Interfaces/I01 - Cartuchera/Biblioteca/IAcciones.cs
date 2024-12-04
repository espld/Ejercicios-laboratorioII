using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IAcciones
    {
        //Propiedades
        public ConsoleColor Color { get; set;}
        public float UnidadesDeEscritura { get; set;}

        //Metodos
        public EscrituraWrapper Escribir(string texto);
        public bool Recargar(int unidades);
       
    }
}
