using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EJ_15
{
    public class Calculado
    {

        /*
                Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
                a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
                operación matemática. El método devolverá el resultado de la operación.
                b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
                utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
                TRUE si el número es distinto de CERO.
         */

        public static int Calcular(int primerNumero, int segundoNumero, char operacionMatematica)
        {
            int resultado;
            

            switch (operacionMatematica)
            {
                case '+':
                    resultado =  primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado =  primerNumero * segundoNumero;
                    break;
                case '/':
                    if (Validar(segundoNumero) == true)
                    {
                        resultado =  primerNumero / segundoNumero;
                    }  
                    else
                    {
                        resultado =  -1111111;
                    }
                    break;
                default:
                    resultado = -111111;
                    break;
            }

            return resultado;
            
        }

        private static bool Validar(int segundoNumero)
        {
            if (segundoNumero == 0)
            {
                return false;
            }
            return true;
        }

    }
}
