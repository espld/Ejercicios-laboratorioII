using System.Text;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre)
            : this()
        {
            this.cantidadJugadores = cantidad;
            this.nombre = nombre;
        }

        //propiedad indexada

        //public Jugador this[int indice]
        //{
        //    get
        //    {
        //        if(indice >= 0 && indice < this.jugadores.Count)
        //        {
        //            return jugadores[indice];
        //        }
        //        return null; ;
        //    }
        //}

        //sobrecargas
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadJugadores)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador == j)
                    {
                        return false;
                    }
                }

                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string MostrarEquipo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Equipo: {this.nombre}");
            sb.AppendLine("\n------JUGADORES------");

            foreach (Jugador jugador in this.jugadores)
            {
                sb.AppendLine(jugador.MostrarDatos());
            }

            return sb.ToString();
        }
    }
}
