using Biblioteca;
using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class FmrMenu : Form
    {
        private Centralita centralita;

        public FmrMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FmrLLamador fmrLlamador = new FmrLLamador(this.centralita);
            fmrLlamador.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }

        private void MostrarFacturacion()
        {
            FmrMostrar informe = new FmrMostrar(this.centralita);

            informe.ShowDialog();

        }

        private void FmrMenu_Load(object sender, EventArgs e)
        {
            this.centralita = new Centralita("CentraLL");
        }
    }
}
