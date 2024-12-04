using System.Text.Json;
using System.Xml.Serialization;

namespace Serializacion_02
{
    public static class SerializadoraJson
    {
        static string ruta;

        static SerializadoraJson()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion2";
        }

        public static void Escribir(Mascota item)
        {

            string completa = ruta + @"\Serializadora_Mascota.json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string objetoJson = JsonSerializer.Serialize(item);

                File.WriteAllText(completa, objetoJson);
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static Mascota Leer()
        {
            Mascota mascota = null;
            string completa = ruta + @"\Serializadora_Mascota.json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string archivoJson = File.ReadAllText(completa);
                mascota = JsonSerializer.Deserialize<Mascota>(archivoJson);

                return mascota;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

    }
}
