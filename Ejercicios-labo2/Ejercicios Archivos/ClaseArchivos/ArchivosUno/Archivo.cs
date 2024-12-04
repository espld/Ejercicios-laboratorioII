namespace ArchivosUno
{
    public static class Archivo
    {

        public static string ruta;

        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //devuelve la ruta, en este caso el escritorio de la pc que lo corra
            ruta += @"\Archivos"; // crea carpeta Archivos en escritorio. El arroba escapo la contrabarra ' \ '.

        }

        public static void Escribir(string nombre)
        {
            //string completa = ruta + @"\Laboratorio.txt";
            string completa = ruta + @"\" + nombre + ".txt"; // -> forma más genérica. Recibo el nombre del archivo por parametro. 

            try
            {
                //Si no hago esto va a fallar porque estoy tratando de escribir en una ruta que no existe.
                //Si no existe la ruta, la creo. Si existe, escribo. Usando Directory.
                if(!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                // Using implementa interfaz iDisposal.
                // Crea un objeto dentro del bloque y solo exista dentro del bloque y apenas termine se desapila.
                // Beneficio es que al trabajr con archivos no hace falta abrir y cerrar el archivo. Por error podriamos dejar el archivo abierto. 
                //Using resuelve lo de arriba.
                using (StreamWriter sw = new StreamWriter(completa,true)) //-> true para que siga appendeando un archivo y no lo sobrescriba.
                {
                    sw.WriteLine("Fecha");
                    sw.WriteLine(DateTime.Now.ToString());
                }
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
                    string completa = ruta + @"\Laboratorio.txt";

                    using (StreamReader sr = new StreamReader(completa))
                    {
                        datos = sr.ReadToEnd();


                        //lo de abajo para leer en una línea por si lo necesito.
                        //string linea;
                        //while ( (linea = sr.ReadLine()) != null)
                        //{
                        //    datos += "\n" + linea;
                        //}
                    }
                }

                return datos;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
        }


    }
}
