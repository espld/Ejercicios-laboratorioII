using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class OtraClase
    {

        public void MetodoOtraClase()
        {
			try
			{
				new MiClase(10);
			}
			catch (UnaExcepcion ex)
			{

				throw new MiExcepcion("MetodoInstancia()", ex);
			}
        }

    }
}
