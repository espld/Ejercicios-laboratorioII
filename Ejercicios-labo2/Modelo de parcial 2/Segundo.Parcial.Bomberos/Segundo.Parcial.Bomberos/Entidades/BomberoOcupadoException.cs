using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BomberoOcupadoException: Exception
    {

        public BomberoOcupadoException()
            :base()
        {

        }
        public BomberoOcupadoException(string mensaje)
            :base(mensaje)
        {

        }
        public BomberoOcupadoException(string mensaje,Exception innerException)
            :base(mensaje, innerException)
        {

        }
    }
}
