using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);

    public class Bombero: IArchivo<Bombero>,IArchivo<string>
    {

        public event FinDeSalida MarcarFin;      
        private string nombre;
        private List<Salida> salidas;
        private static string rutaArchivo;
        private static Random random;
      
        public Bombero(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Bombero()
        {
            salidas = new List<Salida>();
        }
        static Bombero()
        {
            rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"Bombero.xml");
            random = new Random();
        }
        public string Nombre 
        {
            get { return this.nombre; }
            set {  this.nombre = value; }
        }
        public List<Salida> Salidas
        {
            get { return this.salidas;}
            set { this.salidas = value; }
        }
        public void Guardar(Bombero info)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                    xmlSerializer.Serialize(sw, info);
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }          
        }
        public Bombero Leer()
        {
            Bombero bombero = null;
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                    bombero = xmlSerializer.Deserialize(sr) as Bombero;
                }

                return bombero;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        void IArchivo<string>.Guardar(string info)
        {
            LogDAO logDAO= new LogDAO();
            logDAO.InsertarLog(info);
        }
        string IArchivo<string>.Leer()
        {
            LogDAO logDAO = new LogDAO();
            return logDAO.LeerLog();
        }
        public void AtenderSalida(int bomberoIndex)
        {
            //1
            Salida salida = new Salida();
            this.Salidas.Add(salida);
            //2
            Thread.Sleep(random.Next(2000, 4000));
            //3
            salida.FinalizarSalida();
            //4
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Salida finalizada. Inicio: {salida.FechaInicio.ToLongTimeString()}");
            stringBuilder.AppendLine($"Fin: {salida.FechaFin.ToLongTimeString()}");
            stringBuilder.AppendLine($"Duración: {salida.TiempoTotal} segundos.");
            ((IArchivo<string>)this).Guardar(stringBuilder.ToString());
            //5
            this.MarcarFin.Invoke(bomberoIndex);
        }


    }
}
