using System.Text;

namespace Biblioteca
{
    public abstract class Aplicacion
    {

        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        //Propiedades
        public SistemaOperativo SistemaOperativo
        {
            get { return this.sistemaOperativo; }
        }
        protected abstract int Tamanio {  get; }

        //Metodos
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.ToString()}");
            sb.AppendLine($"Sistema Operativo: {this.SistemaOperativo}");
            sb.AppendLine($"Tamaño {this.Tamanio} MB");

            return sb.ToString();
        }


        //Sobrecargas

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion aplicacion in listaApp)
            {
                if(aplicacion.nombre == app.nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion aplicacionMasPesada = null;

            foreach (Aplicacion app in listaApp)
            {
                if(aplicacionMasPesada is null || app.Tamanio > aplicacionMasPesada.Tamanio)
                {
                    aplicacionMasPesada = app;
                }
            }
            return aplicacionMasPesada;
        }
        public override string ToString()
        {
            return this.nombre;
        }


    }
}
