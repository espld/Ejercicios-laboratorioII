using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Excepciones;

namespace Files
{
    //4.El constructor de la clase JsonManager estática asignará al atributo file el valor CentroDeAtencion.json.
    //5.Guardar(T elemento) guardará el elemento recibido como parámetro en un archivo de texto:
    //  a.Su contenido será el paramentro "elemento" un objeto y deberá ser convertido a JSON.
    //  b.Dicho archivo será guardado en donde indique el atributo file.
    //  c.De haber un error, se lanzará FilesException.
    //6.Guardar(string file, T elemento) modificará el atributo file y luego hará lo mismo que Guardar(T).

    public static class JsonManager<T> where T : class
    {
        private static string file;

        static JsonManager()
        {
            file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CentroDeAtencion.json");
        }
        public static void Guardar(T elemento)
        {
            try
            {
                string objetoJson = JsonSerializer.Serialize(elemento);
                File.WriteAllText(file, objetoJson);
            }
            catch (Exception e)
            {
                throw new FilesException(e.Message,e);
            }

        }
        public static void Guardar(string file,T elemento)
        {
            JsonManager<T>.file = file;
            JsonManager<T>.Guardar(elemento);                    
        }
    }

}