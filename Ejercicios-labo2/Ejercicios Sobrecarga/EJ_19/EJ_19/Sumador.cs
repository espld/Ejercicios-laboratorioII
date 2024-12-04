using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_19
{
    public class Sumador
    {

        private int cantidadSumas;


        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        /* 
         b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
            siguiente lógica:
            i. En el caso de Sumar(long, long) sumará los valores numéricos
            ii. En el de Sumar(string, string) concatenará las cadenas de texto.
         */

        public long Sumar(long n1, long n2)
        {
            this.cantidadSumas++;
            return n1 + n2;
        }

        public string Sumar(string n1, string n2)
        {
            this.cantidadSumas++;
            return n1 + n2;
        }

        public static explicit operator int(Sumador suma) //Generar una conversión explícita que retorne cantidadSumas.
        {
            return suma.cantidadSumas;
        }
        public static long operator + (Sumador s1, Sumador s2)
            {
                //return s1.cantidadSumas + s2.cantidadSumas;
                return (int)s1 + (int)s2;
            }

        public static bool operator | (Sumador s1,Sumador s2)
        {
            //return s1.cantidadSumas == s2.cantidadSumas;
            return (int)s1 == (int)s2;
        }


    }
}
