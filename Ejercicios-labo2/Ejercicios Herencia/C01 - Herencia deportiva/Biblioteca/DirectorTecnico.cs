using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico : Persona
    {

        private DateTime fechaNacimiento;

        //propiedades
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento;}
            set {  this.fechaNacimiento = value;}
        }

        //constructores
        public DirectorTecnico(string nombre) : base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaDeNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaDeNacimiento;
        }

        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendLine(base.MostrarDatos());           
            sb.AppendLine($"Fecha de Nacimiento: {this.FechaNacimiento.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        } 
        //sobrecargas
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento == dt2.FechaNacimiento;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

    }
}
