using System.Runtime.CompilerServices;
using System.Text;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosJugados;
        protected int partidosGanados;
        protected int partidosPerdidos;
        protected int partidosEmpatados;
        protected int puntuacion;

        protected Equipo(string nombre)
        {
            this.nombre = nombre;           
        }

        //Propiedades
        public string Nombre
        {
            get { return this.nombre; }
        }
        public int PartidosJugados
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }
        public int PartidosGanados
        {
            get { return this.partidosGanados; }
            set { this.partidosGanados = value; }
        }
        public int PartidosPerdidos
        {
            get { return this.partidosPerdidos; }
            set { this.partidosPerdidos = value; }
        }
        public int PartidosEmpatados
        {
            get { return this.partidosEmpatados; }
            set { this.partidosEmpatados= value; }
        }
        public int Puntuacion
        {
            get { return this.puntuacion; }
            set { this.puntuacion = value; }
        }
        public string Tipo
        {
            get { return this.GetType().Name; }
        }

        //Metodos

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");

            return sb.ToString();
        }
        public abstract int GetDificultad();
                
        public static bool JugarPartido(Equipo equipoA,Equipo equipoB)
        {
            if(equipoA.Equals(equipoB))
            {
                equipoA.PartidosJugados += 1;                
                equipoB.PartidosJugados += 1;                
                if(equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.Puntuacion += 3;
                }
                else if(equipoB.GetDificultad() > equipoA.GetDificultad())
                {
                    equipoB.Puntuacion += 3;
                }
                else
                {
                    equipoA.Puntuacion += 1;
                    equipoB.Puntuacion += 1;
                }
                return true;
            }
            return false;
        }

        //Sobrecargas
        public override bool Equals(object? obj)
        {
            //return obj.GetType() == this.GetType();
            //return obj.GetType() == typeof(Equipo);
            return this.Tipo == obj.GetType().Name;
        }
        public static bool operator ==(Equipo equipoA,Equipo equipoB)
        {
            return equipoA.Equals(equipoB) && equipoA.Nombre == equipoB.Nombre;
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }

    }
}
