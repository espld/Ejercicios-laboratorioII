using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static double CalcularDiferenciaEnSegundos(this DateTime fechaFin,DateTime fechaInicio)
        {
            return (fechaFin - fechaInicio).TotalSeconds;
        }
    }
}
