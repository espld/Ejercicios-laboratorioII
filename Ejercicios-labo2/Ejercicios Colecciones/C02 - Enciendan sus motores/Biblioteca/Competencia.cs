using System.Runtime.CompilerServices;
using System.Text;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas,short cantidadCompetidores) :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        //sobrecargas
        public static bool operator ==(Competencia c,AutoF1 a)
        {

            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores)
            {
                if(c != a)
                {
                    c.competidores.Add(a);
                    a.SetEnCompetencia(true); //= true;
                    a.SetVueltasRestantes(c.cantidadVueltas);// = c.cantidadVueltas;
                    Random rnd = new Random();
                    a.SetCantidadCombustible((short)rnd.Next(15, 100));// = (short)rnd.Next(15,100);
                    return true;
                }
            }         
            return false;          
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine("----------------------------------------");
            if (this.competidores != null)
            {
                foreach (AutoF1 auto in this.competidores)
                {
                    sb.AppendLine($"Competidores: {auto.MostrarDatos()}");
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
