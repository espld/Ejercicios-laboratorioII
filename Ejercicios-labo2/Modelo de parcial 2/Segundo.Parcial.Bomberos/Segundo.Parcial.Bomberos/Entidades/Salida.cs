using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public Salida()
        {
            this.fechaInicio = DateTime.Now;
        }

        public DateTime FechaFin
        {
            get { return this.fechaFin; }
            set { this.fechaFin = value; }
        }
        public DateTime FechaInicio
        {
            get { return this.fechaInicio; }
            set { this.fechaInicio = value;}
        }
        public double TiempoTotal
        {
            get
            {
                return Entension.CalcularDiferenciaEnSegundos(this.FechaFin, this.FechaInicio);
            }
        }

        public void FinalizarSalida()
        {
            this.fechaFin = DateTime.Now;
        }
    }
}
