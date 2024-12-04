using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Biblioteca
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        private Estacionamiento(string nombre,int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }

        //Propiedades
        public List<Vehiculo> ListadoVehiculos
        {
            get {  return this.listadoVehiculos;}
        }
        public string Nombre
        {
            get { return this.nombre;}
        }

        //Metodos
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);               
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;         
            }
            return Estacionamiento.estacionamiento;
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del estacionamiento: {this.Nombre}");
            sb.AppendLine($"Datos: {vehiculo.ToString()}");
            sb.AppendLine($"Hora de salida: {vehiculo.HoraEgreso}");
            sb.AppendLine($"Costo de estadia: {vehiculo.CostoEstadia}");

            return sb.ToString();
        }

        //Sobrecargas
        public static bool operator ==(Estacionamiento estacionamiento,Vehiculo vehiculo)
        {
            foreach (Vehiculo v in estacionamiento.ListadoVehiculos)
            {
                if(v == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static bool operator +(Estacionamiento estacionamiento,Vehiculo vehiculo)
        {
            if(estacionamiento.ListadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                estacionamiento.listadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                estacionamiento.listadoVehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }


    }
}
