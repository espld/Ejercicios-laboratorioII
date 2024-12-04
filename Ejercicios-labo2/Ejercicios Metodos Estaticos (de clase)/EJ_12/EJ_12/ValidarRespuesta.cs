using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_12
{
    public class ValidarRespuesta
    {

        //El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

        public static bool ValidaS_N(char c)
        {
            
            if(c == 's')
            {
                return true;
            }
            return false;

        }

    }
}
