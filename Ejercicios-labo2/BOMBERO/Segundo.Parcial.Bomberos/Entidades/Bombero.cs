using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);

    public class Bombero: IArchivo<Bombero>, IArchivo<string>
    {
        public event FinDeSalida MarcarFin;
        private string nombre;
        private List<Salida> salidas;
        private static string rutaArchivo;
        private static string rutaArchivoJson;
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
            rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bombero.xml");
            rutaArchivoJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bombero.json");
            random = new Random();
        }
        //Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public List<Salida> Salidas
        {
            get { return this.salidas; }
            set { this.salidas = value; }
        }
        //Metodos
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

                throw new Exception() ;
            }
        }
        public Bombero Leer()
        {
            try
            {
                using (StreamReader st = new StreamReader(rutaArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                    return xmlSerializer.Deserialize(st) as Bombero;
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        //JSON POR LAS DUDAS
        //public void GuardarJson(Bombero info)
        //{
        //    try
        //    {
        //        string objetoJson = JsonSerializer.Serialize(info);

        //        File.WriteAllText(rutaArchivoJson, objetoJson);
        //    }
        //    catch (Exception)
        //    {

        //        throw new Exception();
        //    }
        //}
        //public Bombero LeerJson()
        //{
        //    try
        //    {
        //        string archivoJson = File.ReadAllText(rutaArchivoJson);
        //        return JsonSerializer.Deserialize<Bombero>(rutaArchivoJson);
        //    }
        //    catch (Exception)
        //    {

        //        throw new Exception();
        //    }
        //}

        void IArchivo<string>.Guardar(string info)
        {
            LogDAO logDAO = new LogDAO();
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
            this.salidas.Add(salida);
            //2
            Thread.Sleep(random.Next(2000, 4000));
            //3
            salida.FinalizarSalida();
            //4
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Inicio: {salida.FechaInicio}");
            sb.AppendLine($"Fin: {salida.FechaFin}");
            sb.AppendLine($"Duracion total: {salida.TiempoTotal} segundos");
            ((IArchivo<string>)this).Guardar(sb.ToString());
            //5
            MarcarFin.Invoke(bomberoIndex);
        }
    }
}
