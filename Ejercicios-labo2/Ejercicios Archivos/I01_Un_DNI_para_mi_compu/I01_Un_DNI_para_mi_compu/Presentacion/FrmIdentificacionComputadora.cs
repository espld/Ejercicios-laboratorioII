using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.lblNombreMaquina.Text += $" {Environment.UserName}";
            this.lblSistemaOperativo.Text += $" {Environment.OSVersion}";
            this.lblCantProcesadores.Text += $" {Environment.ProcessorCount} procesadores lógicos";
            this.lblDirectorioActual.Text += $" {Environment.NewLine}{Environment.CurrentDirectory}";
            this.ConfigurarLogoSistemaOperativo();
            this.ConfigurarArquitectura();
            this.ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else if(OperatingSystem.IsLinux())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
        }
        private void ConfigurarArquitectura()
        {
            if(Environment.Is64BitOperatingSystem)
            {
                this.lblArquitectura.Text += "Arquitectura de 64bits";
            }
            else
            {
                this.lblArquitectura.Text += "Arquitectura: 32 bits";
            }
        }
        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioTotalBytes = 0;
            long espacioDisponibleBytes = 0;

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                espacioTotalBytes += drive.TotalSize;
                espacioDisponibleBytes += drive.AvailableFreeSpace;
            }

            double espacioTotal = Math.Round(espacioTotalBytes * 9.31e-10);
            double espacioDisponible = Math.Round(espacioDisponibleBytes * 9.31e-10);

            lblEspacioTotal.Text = $"Espacio total: {espacioTotal} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {espacioDisponible} Gigabytes";
        }

    }
}
