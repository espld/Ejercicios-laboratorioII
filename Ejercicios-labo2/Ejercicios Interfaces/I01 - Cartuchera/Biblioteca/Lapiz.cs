using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz: IAcciones
    {

        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina;}
            set { this.tamanioMina = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.tamanioMina -= (float)texto.Length * 0.1f;

            return new EscrituraWrapper(texto, ConsoleColor.Gray);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Lapiz con color de escritura {((IAcciones)this).Color} y su nivel es {((IAcciones)this).UnidadesDeEscritura}";
        }

    }
}
