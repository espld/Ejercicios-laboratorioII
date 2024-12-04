using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Moto: Vehiculo
    {

        public enum ETipo { Cicliomotor,Scooter,Sport}
        private ETipo tipo;
        private static double valorHora;       

        static Moto()
        {
            Moto.valorHora = 100;
        }
        public Moto(string patente,DateTime horaIngreso,ETipo tipo)
            :base(patente,horaIngreso)
        {
            this.tipo = tipo;
        }
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }

        public override double CostoEstadia
        {
            get { return this.CargoDeEstacionamiento(); }
        }

        public override string Descripcion
        {
            get { return this.tipo.ToString(); }
        }

        //Metodos
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*****MOTO*****");
            sb.AppendLine($"Tipo de moto:{this.Descripcion}");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Costo de estadia: {this.CostoEstadia}");

            return sb.ToString();
        }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * valorHora;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
