using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Dispositivo
    {

        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if(app.SistemaOperativo == Dispositivo.sistemaOperativo)
            {
                //Dispositivo.appsInstaladas.Add(app);
                //return true;
                return appsInstaladas + app;
            }
            return false;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sistema operativo: {Dispositivo.sistemaOperativo}{Environment.NewLine}");
            foreach (Aplicacion app in appsInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacionApp());
            }

            return sb.ToString();
        }

    }
}
