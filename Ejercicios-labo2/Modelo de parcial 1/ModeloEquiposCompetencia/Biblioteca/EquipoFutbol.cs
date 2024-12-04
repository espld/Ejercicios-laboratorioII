using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoFutbol: Equipo
    {

        private bool jugadoresEstrellas;

        public EquipoFutbol(string nombre)
            :base(nombre)
        {
            this.jugadoresEstrellas = false;
        }
        public EquipoFutbol(string nombre,bool jugadoresEstrellas)
            :this(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }

        //Metodos
        public override int GetDificultad()
        {
            Random random = new Random();

            if(this.jugadoresEstrellas == true)
            {
                return (random.Next(7, 10) * 2);
            }
            return random.Next(7, 10);

        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Futbol - ");
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }


    }
}
