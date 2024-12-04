using Centralita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CentralitaXX
    {

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public CentralitaXX()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public CentralitaXX(string nombreEmpresa)
            : this() 
        {
            this.razonSocial = nombreEmpresa;
        }

        //Propiedades
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.ETipoLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.ETipoLlamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Llamada.ETipoLlamada.Todas); }
        }
        public List<Llamada> LLamadas
        {
            get { return this.listaDeLlamadas; }
        }

        //Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia llamados locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia llamados Provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancia total: {this.GananciasPorTotal}");
            sb.AppendLine("---------------------------------\n\n*******Listado de llamadas*******");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }
            return sb.ToString();
        }

        private float CalcularGanancia(Llamada.ETipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (Llamada llamada in this.LLamadas)
            {
                if(llamada is Local)
                {
                    gananciaLocal += ((Local)llamada).CostoLlamada;
                }
                else if(llamada is Provincial)
                {
                    gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }

            if(tipo == Llamada.ETipoLlamada.Local)
            {
                return gananciaLocal;
            }
            else if(tipo == Llamada.ETipoLlamada.Provincial)
            {
                return gananciaProvincial;
            }
            else
            {
                return gananciaLocal + gananciaProvincial;
            }


        }

    }
}
