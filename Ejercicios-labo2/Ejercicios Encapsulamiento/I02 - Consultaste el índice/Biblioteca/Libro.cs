namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public Libro() 
        { 
            paginas = new List<string>();
        }
        

        public string this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < this.paginas.Count)
                {
                    return paginas[indice];
                }
                return "No existe";
            }
            set
            {
                if (indice > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else if (indice >= 0)
                {
                    this.paginas.Insert(indice, value);
                }
            }
        }
        

    }
}
