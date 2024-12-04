using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaDeCreacion;

        public Equipo(string nombre, DateTime fechaDeCreacion)
        {
            this.nombre = nombre;
            this.fechaDeCreacion = fechaDeCreacion;
        }

        public string Nombre { get {  return nombre; } }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre} fundado el {this.fechaDeCreacion.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaDeCreacion == e2.fechaDeCreacion ;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

    }
}
