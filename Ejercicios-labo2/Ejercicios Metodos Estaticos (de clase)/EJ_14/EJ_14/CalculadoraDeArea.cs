using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_14
{
    public class CalculadoraDeArea
    {
        /* 
                Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
                cálculo del área que corresponda:
                a. double CalcularCuadrado(double)
                b. double CalcularTriangulo(double, double)
                c. double CalcularCirculo(double) 
         */


        public static double CalcularCuadrado(double ladoA)
        {
            double areaCuadrado = ladoA * ladoA;

            return areaCuadrado;
        }

        public static double CalcularTriangulo(double baseTri, double altura)
        {
            double areaTriangulo = (baseTri * altura) / 2;

            return areaTriangulo;
        }

        public static double CalcularCirculo(double radio)
        {
            //double pi = Math.PI;

            double areaCirculo = Math.PI * (radio * radio);

            return areaCirculo;

        }

    }
}
