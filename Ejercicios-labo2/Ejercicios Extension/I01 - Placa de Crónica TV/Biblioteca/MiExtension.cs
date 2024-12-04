namespace Biblioteca
{
    public static class MiExtension
    {
        //public static string ObtenerPlacaCronica(this DateTime fechaDeHoy,EEstaciones estacion)
        //{
        //    DateTime inicioVerano = new DateTime(2024, 12, 21);
        //    DateTime inicioOtonio = new DateTime(2025, 3, 21);
        //    DateTime inicioInvierno = new DateTime(2024, 6, 21);
        //    DateTime inicioPrimavera = new DateTime(2024, 9, 21);

        //    //if(estacion == EEstaciones.Verano)
        //    //{
        //    //    return $"Faltan {((int)(inicioVerano - fechaDeHoy).TotalDays)} días para el verano";
        //    //}

        //    //return $"ni idea bro";

        //    switch (estacion)
        //    {
        //        case EEstaciones.Otonio:
        //            return $"Faltan {((int)(inicioOtonio - fechaDeHoy).TotalDays)} días para el otoño";
        //            break;
        //        case EEstaciones.Invierno:
        //            return $"Faltan {((int)(inicioInvierno - fechaDeHoy).TotalDays)} días para el invierno";
        //            break;
        //        case EEstaciones.Primavera:
        //            return $"Faltan {((int)(inicioPrimavera - fechaDeHoy).TotalDays)} días para la primavera";
        //            break;
        //        case EEstaciones.Verano:
        //            return $"Faltan {((int)(inicioVerano - fechaDeHoy).TotalDays)} días para el verano";
        //            break;
        //        default: return "error";
        //            break;
        //    }
        //}

        public static string ObtenerPlacaCronicaTV(this DateTime date, EEstaciones estacion)
        {
            DateTime proximaFechaEstacion = ObtenerProximaFechaEstacion(date, estacion);
            TimeSpan diferencia = proximaFechaEstacion - date;
            return $"Faltan {Math.Ceiling(diferencia.TotalDays)} días para el {Enum.GetName(typeof(EEstaciones), estacion)}";
        }

        private static DateTime ObtenerProximaFechaEstacion(DateTime date, EEstaciones estacion)
        {
            int year = date.Year;
            DateTime fechaEstacion;

            switch (estacion)
            {
                case EEstaciones.Verano:
                    fechaEstacion = new DateTime(year, 12, 21);
                    break;
                case EEstaciones.Primavera:
                    fechaEstacion = new DateTime(year, 9, 23);
                    break;
                case EEstaciones.Invierno:
                    fechaEstacion = new DateTime(year, 6, 21);
                    break;
                case EEstaciones.Otonio:
                    fechaEstacion = new DateTime(year, 3, 20);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(estacion), estacion, null);
            }

            if (fechaEstacion < date)
            {
                fechaEstacion = fechaEstacion.AddYears(1);
            }

            return fechaEstacion;
        }
    }
}
