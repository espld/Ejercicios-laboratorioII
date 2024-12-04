using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosUno
{
    public static class ArchivoDos
    {
        public static string ruta;


        static ArchivoDos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos";
        }

        public static void Escribir()
        {
            string completa = ruta + @"\Laboratorio2ParteDos" + DateTime.Now.ToString("HH_mm_ss") + ".txt";

            try
            {
                //Si no hago esto va a fallar porque estoy tratando de escribir en una ruta que no existe.
                //Si no existe la ruta, la creo. Si existe, escribo. Usando Directory.
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string datos = "Otra forma de escribir archivos";
                

                //No hace falta usar using porque el metodo WriteAllText ya lo implementa.
                File.WriteAllText(completa,datos);
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

        }

        public static string Leer()
        {
            try
            {
                string datos = string.Empty;

                if (Directory.Exists(ruta))
                {
                    string completa = ruta + @"\Laboratorio2ParteDos13_28_18.txt";

                    //Creo que esto tambien implementa el using en algun lado
                    datos = File.ReadAllText(completa);
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
        }

    }
}
