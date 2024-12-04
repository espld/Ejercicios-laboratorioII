using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_13
{
    public class Conversor
    {

        /*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):

        string DecimalBinario(int). Convierte un número de entero a binario.
        int BinarioDecimal(string). Convierte un número binario a entero.
        NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.*/


        public static string DecimalABinario(int n)
        {
            /*División sucesiva por 2:

            Divide el número decimal por 2.
            Anota el cociente y el residuo.
            Usa el cociente como el nuevo dividendo y repite el proceso hasta que el cociente sea 0.*/

            int cociente = n;           
            string numeroBinario = "";
          
            while(cociente != 0)
            {
                int resto = cociente % 2;
                cociente = cociente / 2;             
                numeroBinario = resto.ToString() + numeroBinario;
         
            }
            return numeroBinario;
        }


        public static int BinarioADecimal(string str)
        {
            double resultado = 0;
            string valorBinario = str; 
            for (int i = valorBinario.Length - 1; i >= 0; i--)
            {
                if (valorBinario[i] == '1')
                {
                    resultado += Math.Pow(2, valorBinario.Length - 1 - i);
                }
            }
            
            return (int)resultado;
        }



    }
}
