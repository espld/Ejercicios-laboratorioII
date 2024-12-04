using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ParametrosVaciosException: Exception
    {

        public ParametrosVaciosException() :this("Ingrese datos")
        {

        }
        public ParametrosVaciosException(string mensaje) :base(mensaje) 
        {
        
        }


    }
}
