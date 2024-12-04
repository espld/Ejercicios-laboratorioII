using System.Text;

namespace Biblioteca
{
    public class Torneo<T> where T : Equipo
    {
        protected string nombre;
        protected List<T> equipos;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            equipos = new List<T>();
        }

        public string Nombre
        { 
            get { return nombre; } 
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del torneo: {this.Nombre}");
            foreach ( T item in equipos ) 
            {
                sb.AppendLine(item.Ficha()); 
            }

            return sb.ToString();
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if(item == equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo is not null && equipo is not null)
            {
                if(torneo != equipo)
                {
                    torneo.equipos.Add(equipo);
                    return true;
                }
            }
            return false;
        }

        private string CalcularPartido(T e1, T e2)
        {           
            Random random = new Random();

            return $"{e1.Nombre}: {random.Next(1, 10)} - {e2.Nombre}: {random.Next(1, 10)}";
        }

        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = equipos[random.Next(0, equipos.Count)];
                    equipo2 = equipos[random.Next(0, equipos.Count)];

                } while (equipo1 == equipo2);

                return CalcularPartido(equipo1, equipo2);
            }
        }


    }
}
