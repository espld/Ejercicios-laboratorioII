using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        /*
         Deberá tener los atributos:

            nombre
            fechaDeNacimiento
            dni
            Deberá tener un constructor que inicialice todos los atributos.

            Construir los siguientes métodos para la clase:

            Setter y getter para cada uno de los atributos.
            CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
            Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
            EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
         
         */

        private string nombre;
        private int fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, int fechaDeNacimiento,int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        /*
            Setter y getter para cada uno de los atributos.
            
         */

        //GET
        public string GetNombre()
        {
            return this.nombre;
        }
        public int GetFecha()
        {
            return this.fechaDeNacimiento;
        }
        public int GetDni()
        {
            return this.dni;
        }
        public void SetNombre(string n)
        {
            this.nombre = n;
        }
        public void SetFecha(int f)
        {
            this.fechaDeNacimiento = f;
        }
        public void SetDni(int d)
        {
            this.dni = d;
        }
        /*
            CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
            Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
            EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
         */

        private int CalcularEdad()
        {
            DateTime dateTime = DateTime.Now;

            int fechaActual = dateTime.Year;
            int fechaNacimiento = this.fechaDeNacimiento;

            int edad = fechaActual - fechaNacimiento;

            return edad;
        }

        private string EsMayorEdad()
        {
            if(CalcularEdad() > 17)
            {
                return "Es mayor de edad";
            }
            return "Es menor";
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de Nacimiento: {this.fechaDeNacimiento}");
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Edad actual: {CalcularEdad()}");
            sb.AppendLine(EsMayorEdad());

            return sb.ToString();
        }

    }
}
