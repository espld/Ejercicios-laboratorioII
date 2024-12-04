using Biblioteca;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reloj reloj = new Reloj();
            reloj.SegundoCambiado += MostrarCambioTiempo;
            reloj.Ejecutar();
        }

        public void MostrarCambioTiempo(object reloj, InfoTiempoEventArgs info)
        {
            lblTiempo.Text = $"{info.hora}{info.minuto}{info.segundo}";
        }

    }
}
