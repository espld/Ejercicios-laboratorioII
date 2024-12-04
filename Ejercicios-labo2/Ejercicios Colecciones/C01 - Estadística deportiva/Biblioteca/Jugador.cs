using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;
        }
        public Jugador(int dni,string nombre)
            :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            :this(dni,nombre)
        { 
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        //get
        public float GetPromedioGoles()
        {
            return (float)this.totalGoles /this.partidosJugados;
        }

        //sobrecargas
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Partidos Jugados: {this.partidosJugados}");
            sb.AppendLine($"Total de Goles: {this.totalGoles}");
            sb.AppendLine($"Promedio de gol: {this.GetPromedioGoles().ToString("F1")}");

            return sb.ToString();
        }
    }
}
