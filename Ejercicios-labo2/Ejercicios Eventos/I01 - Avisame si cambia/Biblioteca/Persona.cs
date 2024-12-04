namespace Biblioteca
{

    public class Persona
    {
        public delegate void DelegadoString(string mensaje);
        public event DelegadoString EventoString;
        private string apellido;
        private string nombre;

        public Persona()
        {
            this.apellido = string.Empty;
            this.nombre = string.Empty;
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                this.apellido = value;
                if (EventoString is not null)
                {
                    this.EventoString.Invoke($"Apellido: {this.apellido}"); //LANZO EL EVENTO CON EL INVOKE.
                }
            }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = value;
                if (EventoString is not null)
                {
                    this.EventoString.Invoke($"Nombre: {this.Nombre}"); //LANZO EL EVENTO CON EL INVOKE.
                }
            }
        }

        //Metodos
        public string Mostrar()
        {
            return $"{this.Nombre} {this.Apellido}";
        }



    }
}
