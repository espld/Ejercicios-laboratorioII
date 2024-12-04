using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        //Metodos
        public string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float gananciaTotal = 0;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(vendedor.nombre.ToUpper());
            sb.AppendLine("-----------");
            foreach (Publicacion publi in vendedor.ventas)
            {
                sb.AppendLine($"PUBLICACION: {publi.ObtenerInformacion()}");
                gananciaTotal += publi.Importe;
            }
            
            sb.AppendLine($"Ganancia total: {gananciaTotal}");

            return sb.ToString();
        }

        //Sobrecarga

        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if(publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock -= 1;
                return true;
            }
            return false;
        }

    }
}
