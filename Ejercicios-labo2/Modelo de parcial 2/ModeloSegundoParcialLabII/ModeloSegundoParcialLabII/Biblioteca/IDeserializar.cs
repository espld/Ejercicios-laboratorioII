using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IDeserializar
    {
        public bool Xml(string path, out Fruta fruta);
    }
}
