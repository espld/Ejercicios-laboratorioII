using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoBasket: Equipo
    {
        public enum ELiga
        {
            NBA,
            Euroleague,
            ACB
        }

        private ELiga liga;

        public EquipoBasket(string nombre)
            :base(nombre)
        {
            this.liga = ELiga.NBA;
        }
        public EquipoBasket(string nombre, ELiga liga)
            :this(nombre)
        {
            this.liga = liga;
        }

        //Metodos
        public override int GetDificultad()
        {
            Random random = new Random();

            if(this.liga == ELiga.NBA)
            {
                return random.Next(8,10);
            }
            else if(this.liga == ELiga.Euroleague)
            {
                return random.Next(5,10);
            }
            else if(this.liga == ELiga.ACB)
            {
                return random.Next(1,7);
            }
            return 0;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Basket - ");
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
