using System.Numerics;

namespace IO
{
    public static class ArchivoTexto
    {
        static string ruta;

        static ArchivoTexto()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\EjercicioArchivo";
        }

        public static void Guardar(string nombreArchivo, string informacionAGuardar)
        {
            string rutaCompleta = ruta + @"\" + nombreArchivo + ".txt";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                //File.WriteAllText(rutaCompleta, informacionAGuardar + Environment.NewLine); //Si es algo de una linea, sino el de abajo que no sobrescribe lo anterior.
                File.AppendAllText(rutaCompleta,informacionAGuardar + Environment.NewLine);                
            }
            catch (Exception)
            {
                throw new Exception($"Error en la ruta {ruta}");
            }
        }

        public static string Leer(string nombreArchivo)
        {
            try
            {
                string datos = string.Empty;

                if (Directory.Exists(ruta))
                {
                    string rutaCompleta = ruta + @"\" + nombreArchivo + ".txt";

                    datos = File.ReadAllText(rutaCompleta);
                }

                return datos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la ruta {ruta}");
            }
        }

        //public static bool Guardar(string nombreArchivo, string texto)
        //{
        //    StreamWriter streamWriter = null;
        //    try
        //    {
        //        streamWriter = new StreamWriter(nombreArchivo, true);
        //        streamWriter.WriteLine(texto);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (streamWriter != null)
        //        {
        //            streamWriter.Close();
        //        }
        //    }
        //    return true;
        //}
        //public static string Leer(string nombreArchivo)
        //{
        //    StreamReader streamReader = null;
        //    string textoLeido = string.Empty;
        //    try
        //    {
        //        streamReader = new StreamReader(nombreArchivo);
        //        textoLeido = streamReader.ReadToEnd();
        //        return textoLeido;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (streamReader != null)
        //        {
        //            streamReader.Close();
        //        }
        //    }
        //}


    }
}
