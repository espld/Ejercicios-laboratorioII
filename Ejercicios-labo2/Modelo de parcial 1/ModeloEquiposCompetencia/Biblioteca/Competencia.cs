using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {

        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        private Competencia(string nombre)
        {
            this.nombre = nombre;
            this.cantidadCompetidores = 5;
        }
        public Competencia(string nombre, int cantidadCompetidores)
            :this(nombre)
        {
            this.equipos = new List<Equipo>();
            this.cantidadCompetidores = cantidadCompetidores;
        }

        //Propiedades
        public int CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public List<Equipo> Equipos
        {
            get { return this.equipos;}
        }
        public string Nombre
        {
            get { return this.nombre;}
            set { this.nombre = value;}
        }

        //Metodos
        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del torneo: {torneo.Nombre}");
            sb.AppendLine($"Cantidad de competidores: {torneo.CantidadCompetidores}");

            foreach (Equipo equipo in torneo.equipos)
            {
                sb.AppendLine(equipo.ToString());
            }

            return sb.ToString();
        }

        //Sobrecargas
        public static bool operator ==(Competencia torneo,Equipo equipo)
        {
            foreach (Equipo eq in torneo.equipos)
            {
                if(eq == equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }
        public static Competencia operator +(Competencia torneo,Equipo equipo)
        {
            //if(torneo.equipos.Count < torneo.CantidadCompetidores)
            //{
            //    foreach (Equipo eq in torneo.equipos)
            //    {
            //        if(eq != equipo)
            //        {
            //            torneo.equipos.Add(eq);
            //        }
            //    }
            //    return torneo;
            //}
            //else
            //{
            //    return torneo;
            //}

            if(torneo.equipos.Count < torneo.cantidadCompetidores && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return torneo;
            }
            return torneo;

        }
        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }

    }
}
