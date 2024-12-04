using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MiClase
    {

        public static void Metodo()
        {
            throw new DivideByZeroException();
        }

        public MiClase()
        {
            try
            {
                MiClase.Metodo();
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public MiClase(int n1)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {

                throw new UnaExcepcion("MiClase(int num1)", ex);
            }
        }

    }
}
