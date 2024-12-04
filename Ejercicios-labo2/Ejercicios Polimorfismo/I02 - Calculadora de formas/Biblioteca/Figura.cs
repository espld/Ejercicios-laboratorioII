namespace Biblioteca
{
     public abstract class Figura
    {

        public virtual string Dibujar()
        {
            return "Dibujando...";
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro(); 

        

    }
}
