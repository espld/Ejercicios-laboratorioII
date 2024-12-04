using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        private AutoF1(bool enCompetencia, short cantidadCombustible, short vueltasRestantes)
        {
            this.enCompetencia = enCompetencia;
            this.cantidadCombustible = cantidadCombustible;
            this.vueltasRestantes = vueltasRestantes;
        }
        //private AutoF1()
        //{
        //    this.enCompetencia = false;
        //    this.cantidadCombustible = 0;
        //    this.vueltasRestantes = 0;
        //}

        public AutoF1(short numero,string escuderia)
            :this(false,0,0)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        //prop
        //public short CantidadCombustible
        //{
        //    get { return cantidadCombustible; }
        //    set { cantidadCombustible = value; }
        //}
        //public bool EnCompetencia
        //{
        //    get { return enCompetencia; }
        //    set {  enCompetencia = value; }
        //}
        //public short VueltasRestantes
        //{
        //    get { return vueltasRestantes; }
        //    set {  vueltasRestantes = value;}
        //}
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }
        public void SetCantidadCombustible(short valor)
        {
            this.cantidadCombustible = valor;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
        public void SetVueltasRestantes(short valor)
        {
            this.vueltasRestantes = valor;
        }
        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }
        public void SetEnCompetencia(bool estado)
        {
              this.enCompetencia = estado;
        }

        //sobrecargas

        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1,AutoF1 a2)
        {
            return !(a1 == a2);
        }

        //metodos
        //public string MostrarDatos()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine($"Escuderia: {this.escuderia}");
        //    sb.AppendLine($"Numero: {this.numero}");
        //    sb.AppendLine($"En competencia?: {this.EnCompetencia}");
        //    sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");
        //    sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");

        //    return sb.ToString();
        //}
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"En competencia?: {this.GetEnCompetencia()}");
            sb.AppendLine($"Vueltas restantes: {this.GetVueltasRestantes()}");
            sb.AppendLine($"Cantidad de combustible: {this.GetCantidadCombustible()}");

            return sb.ToString();
        }
    }
}
