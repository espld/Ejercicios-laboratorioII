using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class UsuarioDto
    {
        //MODELO IDENTICO A LA BASE DE DATOS, PORQUE DESPUES HAY QUE MAPEARLO.
        //REPRESENTACION EN CODIGO DE LAS TABLAS

        //DTO DATA TRANSFER OBJECT
        //OBJETOS QUE SE USAN PARA PASAR INFORMACION. DE LA BASE DE DATOS LO PASO A OBJETOS.
        //OBJETOS QUE REPRESENTAN A LA BASE DE DATOS

        private string userName;
        private int codigoUsuario;

        public UsuarioDto(string userName, int codigoUsuario)
        {
            this.UserName = userName;
            this.CodigoUsuario = codigoUsuario;
        }

        public string UserName { get => userName; set => userName = value; }
        public int CodigoUsuario { get => codigoUsuario; set => codigoUsuario = value; }

        public override string ToString()
        {
            return UserName;
        }


    }
}
