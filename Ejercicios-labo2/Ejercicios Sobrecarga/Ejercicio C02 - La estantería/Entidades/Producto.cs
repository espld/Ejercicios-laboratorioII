using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
         public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {p.GetMarca()}");
            sb.AppendLine($"Precio: {p.GetPrecio()}");
            //sb.AppendLine($"Codigo de barra: {p.codigoDeBarra}");
            sb.AppendLine($"Codigo de barra: {(string)p}");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;         
        }
        public static bool operator ==(Producto p, String marca)
        {
            //if(p.marca == marca)
            //{
            //    return true;
            //}
            //return false;

            return p.marca == marca;
        }
        public static bool operator !=(Producto p, String marca)
        {
            //if(!(p.marca == marca))
            //{
            //    return false;
            //}
            //return true;

            return !(p.marca == marca);

        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            //if(p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca) 
            //{
            //    return true;
            //}
            //return false;

            return (string)p1 == (string)p2 && p1.GetMarca() == p2.GetMarca();
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            //if (!(p1 == p2))
            //{
            //    return true;
            //}
            //return false;

            return !(p1 == p2);

        }






    }
}
