using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad,int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}");
            sb.AppendLine($"Productos: ");
            foreach (Producto p in e.GetProductos())
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }

            return sb.ToString();
        }

        /*
         ==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
            +: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más 
        y dicho producto no se encuentra en el estante, false caso contrario. Reutilizar código.
            -: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.
         */

        public static bool operator ==(Estante e, Producto p)
        {
            if (e.GetProductos().Contains(p))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e.GetProductos().Contains(p));
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;

                    }
                }
            }

            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;

        }
    }
}
