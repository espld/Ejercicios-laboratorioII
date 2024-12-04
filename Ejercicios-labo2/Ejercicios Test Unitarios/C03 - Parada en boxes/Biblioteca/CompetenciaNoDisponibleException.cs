using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo)
            : base(mensaje)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        //Propiedades

        public string NombreClase
        {
            get { return this.nombreClase; }
        }
        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            Exception ex;

            sb.AppendFormat("Excepción en el método {0} de la clase {1}\n", this.NombreMetodo, this.NombreClase);
            sb.AppendLine("Error: " + this.Message);
            ex = this.InnerException;

            while (ex != null)
            {
                sb.Append("Inner: " + ex.Message + "\t");
                ex = ex.InnerException;
            }
            return sb.ToString();
        }

    }
}
