using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void PrecioExtendido(object sender);

    public class Cajon<T> where T: class
    {
        protected int capacidad;
        protected List<T> elementos;
        protected double precioUnitario;
        public event PrecioExtendido EventoPrecio;

        public Cajon()
        {
            elementos = new List<T>();
        }
        public Cajon(double precio, int capacidad)
            : this(capacidad)
        {
            this.precioUnitario = precio;
        }
        public Cajon(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public List<T> Elementos
        {
            get { return this.elementos; }
        }
        public double PrecioTotal
        {
            get
            {
                double total = this.precioUnitario * elementos.Count;
                if (total > 55)
                {
                    this.EventoPrecio.Invoke(this);
                }
                return total;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad: {this.capacidad}");
            sb.AppendLine($"Cantidad Total elementos: {elementos.Count} ");
            sb.AppendLine($"Precio total: {PrecioTotal}");

            foreach (var item in elementos)
            {
                sb.AppendLine($"{item.ToString()}");
            }

            return sb.ToString();
        }

        public static Cajon<T> operator +(Cajon<T> cajon, T elem)
        {
            if (cajon != null && elem != null)
            {
                if (cajon.capacidad > cajon.elementos.Count)
                {
                    cajon.elementos.Add(elem);
                }
                else
                {
                    throw new CajonLlenoException("Cajon lleno");
                }
            }

            return cajon;
        }

    }
}
