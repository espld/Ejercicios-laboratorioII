using System.Runtime.InteropServices;
using System.Text;

namespace Biblioteca
{
    public abstract class Producto
    {
        protected int codigoDeBarra;
        protected EMarcaProducto marca;
        protected float precio;

        public enum EMarcaProducto
        {
            Manaos,
            Pitusas,
            Diversion,
            Naranju,
            Swift,
            Favorita,
            Tang
        }

        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this.codigoDeBarra = codigoBarra;
            this.marca = marca;
            this.precio = precio;
        }
        public Producto()
        {

        }

        public abstract float CalcularCostoDeProduccion { get; set; }
        public EMarcaProducto Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public int CodigoDeBarra
        {
            get { return this.codigoDeBarra; }
            set { this.codigoDeBarra = value; }
        }

        private string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {p.Marca}");
            sb.AppendLine($"Precio: {p.Precio}");
            sb.AppendLine($"Codigo de Barra: {p.CodigoDeBarra}");

            return sb.ToString();
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }


        public override bool Equals(object? obj)
        {
            return obj is Producto;
        }
        public static bool operator ==(Producto p1,Producto p2)
        {
            return p1.Equals(p2) && p1.Marca == p2.Marca && p1.CodigoDeBarra == p2.CodigoDeBarra;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, EMarcaProducto marca)
        {
            return p1.Marca == marca;
        }
        public static bool operator !=(Producto p1, EMarcaProducto marca)
        {
            return !(p1 == marca);
        }
        public static explicit operator int(Producto producto)
        {
            return producto.CodigoDeBarra;
        }
        public static implicit operator string(Producto producto)
        {
            return producto.MostrarProducto(producto);
        }

    }
}
