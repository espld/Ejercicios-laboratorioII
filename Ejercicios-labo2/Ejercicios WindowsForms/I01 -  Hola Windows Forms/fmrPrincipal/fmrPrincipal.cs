using System.Text;

namespace fmrPrincipal
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {

            string titulo;          
            string mensaje;
            titulo = "Hola windows forms";
            mensaje = $"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {this.cmbMaterias.SelectedItem}";

            if(this.Validar())
            {
                fmrSaludo fmrSaludo = new fmrSaludo(titulo, mensaje);
                fmrSaludo.ShowDialog();
            }

            
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.Items.Add("Programacion II");
            this.cmbMaterias.Items.Add("Laboratorio II");
            this.cmbMaterias.Items.Add("Inglés II");
            this.cmbMaterias.SelectedIndex = 0;
        }

        private bool Validar()
        {

            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                sb.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                sb.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;

        }
    }
}
