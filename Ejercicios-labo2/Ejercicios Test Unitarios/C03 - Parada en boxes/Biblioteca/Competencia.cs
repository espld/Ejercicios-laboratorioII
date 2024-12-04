using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        protected short cantidadCompetidores;
        protected short cantidadVueltas;
        protected List<VehiculoDeCarrera> competidores;
        protected TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        //propiedades
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }
        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }
        public List<VehiculoDeCarrera> ListaDeVehiculos
        {
            get { return this.competidores; }
        }

        //sobrecargas
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            if (c.Tipo == TipoCompetencia.F1 && v.GetType() != typeof(AutoF1) || c.Tipo == TipoCompetencia.MotoCross && v.GetType() != typeof(MotoCross))
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Sobrecarga ==");
            }
            else
            {
                foreach (VehiculoDeCarrera vehiculo in c.competidores)
                {
                    if (vehiculo == v)
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;

        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            try
            {
                if (c.competidores.Count() < c.cantidadCompetidores)
                {
                    if (c != v)
                    {
                        v.EnCompetencia = true;
                        v.VueltasRestantes = c.cantidadVueltas;
                        Random rnd = new Random();
                        v.CantidadCombustible = (short)rnd.Next(15, 100);
                        c.competidores.Add(v);
                        return true;
                    }
                }

            }
            catch (CompetenciaNoDisponibleException ex)
            {

                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "\'Operador +\'", ex);
            }

            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if (c == v)
            {
                c.competidores.Remove(v);
                return true;
            }
            return false;
        }

        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de competidores: {this.CantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.CantidadVueltas}");
            sb.AppendLine("----------------------------------------");
            if (this.competidores != null)
            {
                foreach (VehiculoDeCarrera vehiculo in this.competidores)
                {
                    if (vehiculo.GetType() == typeof(AutoF1))
                    {
                        sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                    }
                    else if (vehiculo.GetType() == typeof(MotoCross))
                    {
                        sb.AppendLine(((MotoCross)vehiculo).MostrarDatos());
                    }
                }
            }
            else
            {
                sb.AppendLine("No hay competidores");
            }

            return sb.ToString();
        }
    }
}
