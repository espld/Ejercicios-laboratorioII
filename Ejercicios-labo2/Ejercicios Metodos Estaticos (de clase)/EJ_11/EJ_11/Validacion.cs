using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_11
{
    public class Validacion
    {
        /* Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la
                siguiente firma: bool Validar(int valor, int min, int max):
                a. valor: dato a validar
                b. min y max: rango en el cual deberá estar la variable valor.*/

        public static bool Validar(int valor, int min, int max)
        {
            if(valor >= min && valor <= max)
            {
                return true;
            }
            return false;
        }


    }
}
