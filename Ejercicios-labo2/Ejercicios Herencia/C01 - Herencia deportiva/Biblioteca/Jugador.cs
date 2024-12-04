using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador: Persona
    {
        private int partidosJugados;
        private int totalGoles;

        //propiedades
        public int PartidosJugados
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }
        public int TotalGoles
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; }
        }
        public float PromedioDeGoles
        {
            get { return (float)this.TotalGoles / this.PartidosJugados; }
        }

        //constructores
        public Jugador(int dni,string nombre) :base(dni,nombre)
        {

        }
        public Jugador(int dni,string nombre,int totalGoles, int totalPartidos)
            :this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {this.PartidosJugados}");
            sb.AppendLine($"Total de goles: {this.TotalGoles}");
            sb.AppendLine($"Promedio de gol: {this.PromedioDeGoles}");

            return sb.ToString();
        }

        //sobrecargas
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


    }
}
