using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {

        protected short cantidadCombustible;
        protected bool enCompetencia;
        protected string escuderia;
        protected short numero;
        protected short vueltasRestantes;     

        public VehiculoDeCarrera(short numero, string escuderia)          
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        //propiedades
        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.EnCompetencia = value; }
        }
        public string Escuderia
        { 
            get { return this.escuderia;}
            set { this.escuderia = value;}
        }
        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Escuderia: {this.Escuderia}");
            sb.AppendLine($"En competencia?: {this.EnCompetencia}");
            sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");

            return sb.ToString();
        }

        //sobrecargas
        public static bool operator ==(VehiculoDeCarrera vc1, VehiculoDeCarrera vc2)
        {
            return vc1.Numero == vc2.Numero && vc1.Escuderia == vc2.Escuderia;
        }
        public static bool operator !=(VehiculoDeCarrera vc1, VehiculoDeCarrera vc2)
        {
            return !(vc1 == vc2);
        }

    }

}
