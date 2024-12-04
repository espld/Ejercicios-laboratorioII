using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad,string nombre)
            :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        //prop
        public short CantidadJugadores
        {
            get { return this.cantidadDeJugadores; }
        }      
        public string Nombre
        {
            get { return this.nombre; }
        }


        /*
         La sobrecarga del operador + agregará jugadores a la lista siempre y 
        cuando no exista aún en el equipo y la cantidad de jugadores no supere el límite establecido 
        por el atributo cantidadDeJugadores.
         */

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    //utilizo sobrecarga de == de la clase Jugador
                    if (item == j)
                        return false;
                }
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }

            //if(e.jugadores.Count < e.cantidadDeJugadores)
            //{
            //    foreach (Jugador jugador in e.jugadores)
            //    {
            //        if(jugador == j)
            //        {
            //            return false;
            //        }
            //        //e.jugadores.Add(j);
            //        return true;
            //    }
            //}
            //return false;


        }

        public string MostrarJugadores()
        {
            if (this.jugadores.Count == 0)
            {
                return "No hay jugadores";
            }

            StringBuilder sb = new StringBuilder();
            foreach (Jugador jugador in jugadores)
            {
                sb.AppendLine(jugador.MostrarDatos());
            }
            return sb.ToString();

        }


    }
}
