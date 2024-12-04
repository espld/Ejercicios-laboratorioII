using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpresaTransporte
    {

        private List<Conductor> conductores;
        private string nombre;       

        public EmpresaTransporte(string nombre)
        {
            this.nombre = nombre;
            this.conductores = new List<Conductor>();
        }

        public void agregarConductor(Conductor conductor)
        {
            this.conductores.Add(conductor);
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string MostrarDatosEmpresa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"******* {this.Nombre.ToUpper()} *******");
            sb.AppendLine($"");
            sb.AppendLine($"CONDUCTORES:");
            foreach( Conductor conductor in this.conductores )
            {
                sb.AppendLine(conductor.MostrarDatos());             
            }

            return sb.ToString();
            
        }

        public void AgregarKmRecorridosPorDia(Conductor c, int hL, int hM, int hMi, int hJ, int hV, int hS, int hD)
        {
            c.KmRecorridosPorDia[0] = hL; //lunes
            c.KmRecorridosPorDia[1] = hM; //martes
            c.KmRecorridosPorDia[2] = hMi; //miercoles
            c.KmRecorridosPorDia[3] = hJ; //jueves
            c.KmRecorridosPorDia[4] = hV; //viernes
            c.KmRecorridosPorDia[5] = hS; //sabado 
            c.KmRecorridosPorDia[6] = hD; //domingo
        }

        public int AcumularKmRecorridos(Conductor c)
        {
            int acumKm = 0;

            for (int i = 0; i < c.KmRecorridosPorDia.Length; i++)
            {
                acumKm += c.KmRecorridosPorDia[i];
            }

            return acumKm;
        }

        public string ConductorConMayorKmPorSemana(Conductor c1, Conductor c2)
        {
            if (AcumularKmRecorridos(c1) > AcumularKmRecorridos(c2))
            {
                return $"El conductor con mas km recorridos en la semana es: {c1.Nombre} {c1.Apellido}";
            }
            return $"El conductor con mas km recorridos en la semana es: {c2.Nombre} {c2.Apellido}";

        }

        public string ConductorConMasKmPorDia(Conductor c1, Conductor c2, int indice)
        {
           
            if(c1.KmRecorridoPorDia(indice) > c2.KmRecorridoPorDia(indice))
            {                              
                return $"El conductor con mayor km recorridos el dia {indice + 1} es {c1.Nombre}";              
            }
            else if(c1.KmRecorridoPorDia(indice) == 0 &&  c2.KmRecorridoPorDia(indice) == 0)
            {
                return "No Trabajaron ese día.";
            }
            
            return $"El conductor con mayor km recorridos el dia {indice + 1} es {c2.Nombre}";    
            
        }

    }
}
