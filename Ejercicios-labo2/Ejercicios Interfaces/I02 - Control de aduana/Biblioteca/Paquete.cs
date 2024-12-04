using System.Text;

namespace Biblioteca
{
    public abstract class Paquete: IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad {get;}

        public decimal Impuestos
        {
            get { return (this.costoEnvio * 35) / 100; }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Código de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio{this.costoEnvio}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso: {this.pesoKg}");
            sb.AppendLine($"Tiene prioridad?: {this.TienePrioridad}");

            return sb.ToString();
        }

        public decimal AplicarImpuestos()
        {
            throw new NotImplementedException();
        }
    }
}
