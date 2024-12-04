using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {

        public enum ETipoProducto
        {
            Galletita,
            Gaseosa,
            Jugo,
            Harina,
            Todos
        }

        protected sbyte capacidad;
        protected List<Producto> productos;

        private Estante()
        {
            productos = new List<Producto>();
        }
        public Estante(sbyte capacidad)
            :this()
        {
            this.capacidad = capacidad;
        }

        public List<Producto> GetProducto()
        {
            return this.productos;
        }

        public string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad: {estante.capacidad}");
            foreach (Producto item in estante.GetProducto())
            {
                sb.AppendLine((string)item);
            }

            return sb.ToString();
        }

        public static  bool operator ==(Estante estante,Producto producto)
        {
            foreach (Producto prod in estante.GetProducto())
            {
                if(prod == producto)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante estante,Producto producto)
        {
            return !(estante == producto);
        }
        public static bool operator +(Estante estante,Producto producto)
        {
            if(estante.productos.Count < estante.capacidad && estante != producto)
            {
                estante.productos.Add(producto);
                return true;
            }
            return false;
        }
        public static Estante operator -(Estante estante,ETipoProducto tipoProducto)
        {
            foreach (Producto item in estante.GetProducto())
            {
                if(item.ToString() == tipoProducto.GetType().Name)
                {
                    estante.productos.Remove(item);
                }
            }
            return estante;
        }
        public static Estante operator -(Estante estante, Producto producto)
        {
            if(estante == producto)
            {
                estante.GetProducto().Remove(producto);
            }
            return estante;
        }


    }
}
