using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        /* 
            Un constructor que permita inicializar todos los atributos. *
            Un método getter para cada atributo. *
            mostrar retornará una cadena de texto con todos los datos de la cuenta.
            ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
         */
        private string titular;
        private decimal cantidad;

        public Cuenta(string  titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        /* 
         mostrar retornará una cadena de texto con todos los datos de la cuenta.
            ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
         */
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Monto actual: {this.cantidad}");

            return sb.ToString();
        }

        public string Ingresar(decimal monto)
        {
            if(monto < 0)
            {
                return "No podes ingresar ese monto";
            }
            else
            {
                this.cantidad += monto;
                return $"Ingresaste {monto}";
            }
        }
        public string Retirar(decimal monto)
        {
            this.cantidad -= monto;
            return $"Retiraste {monto}";
        }


    }
}
