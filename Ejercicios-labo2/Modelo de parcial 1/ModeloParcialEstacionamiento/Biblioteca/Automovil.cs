using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Automovil: Vehiculo
    {
        private string marca;
        private static double valorHora;

        static Automovil()
        {
            Automovil.valorHora = 120;
        }

        public Automovil(string patente,DateTime horaIngreso,string marca)
            :base(patente,horaIngreso)
        {
            this.marca = marca;
        }

        //Propiedades
        public override double CostoEstadia
        {
            get 
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public override string Descripcion
        {
            get { return this.marca; }
        }
        public static double ValorHora
        {
            set
            {
                if(value > 0)
                {
                    Automovil.valorHora = value;
                }
            }
        }

        //Metodos;
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*****AUTOMOVIL*****");
            sb.AppendLine($"Marca: {this.Descripcion}");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Costo de estadia: {this.CostoEstadia}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
