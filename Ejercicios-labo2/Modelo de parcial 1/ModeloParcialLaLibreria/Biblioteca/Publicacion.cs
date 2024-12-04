using System.Text;

namespace Biblioteca
{
    public abstract class Publicacion
    {

        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }
        public Publicacion(string nombre, int stock)
            :this(nombre)
        {
            this.stock = stock;
        }
        public Publicacion(string nombre,int stock,float importe)
            :this(nombre,stock)
        {
            this.importe = importe;
        }

        //Propiedades 
        protected abstract bool EsColor { get; }
        public virtual bool HayStock
        {
            get
            {
                if(this.Stock > 0 && this.Importe > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public float Importe
        {
            get { return this.importe; }
        }
        public int Stock
        {
            get { return this.stock; }
            set
            {
                if(value > 0)
                {
                    this.stock = value;
                }
            }
        }

        //Metodos
        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.ToString()}");
            sb.AppendLine($"Stock: {this.Stock}");
            sb.AppendLine($"Es Color: {this.EsColor}");
            sb.AppendLine($"Valor: {this.Importe}");

            return sb.ToString();
        }

        //Sobrecarga
        public override string ToString()
        {
            return this.nombre;
        }

    }
}
