using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        private int codigoUsuario;
        private string userName;

        public Usuario(string userName, int codigoUsuario)
        {
            this.userName = userName;
            this.codigoUsuario = codigoUsuario;
        }

        public int CodigoUsuario
        {
            get { return this.codigoUsuario; }
        }

        public override string ToString()
        {
            return this.userName;
        }


    }

}
