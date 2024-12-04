using System.Text;

namespace Biblioteca
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;        
        public enum EVehiculos { Automovil, Moto }


        public Vehiculo(string patente,DateTime horaIngreso)
        {
            
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        //Propiedades
        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; } 
        public DateTime HoraEgreso
        {
            get { return this.horaEgreso; }
            set 
            { 
                if(value > this.horaIngreso)
                {
                    this.horaEgreso = value;
                }               
            }
        }
        public DateTime HoraIngreso
        {
            get { return this.horaIngreso;}
        }
        public string Patente
        {
            get { return this.patente; }
            set 
            {
                if(this.ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        //Metodos
        protected virtual double CargoDeEstacionamiento()
        {
            //TimeSpan intervalo;
            //double intervaloDouble;

            //intervalo = this.HoraIngreso - this.HoraEgreso;
            //double.TryParse(intervalo.ToString(), out intervaloDouble);

            //return intervaloDouble;

            return (double)(this.horaIngreso.Hour - this.horaEgreso.Hour);


        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Hora de ingreso: {this.HoraIngreso}");

            return sb.ToString();
        }
        private bool ValidarPatente(string patente)
        {
            if(patente.Length > 5 && patente.Length <8)
            {
                return true;
            }
            return false;
        }

        //Sobrecargas
        public static bool operator ==(Vehiculo v1,Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
}
