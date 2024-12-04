using Biblioteca;

namespace WinFormsApp1
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;

        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(persona == null)
            {
                persona = new Persona();
                btnCrear.Text = "Actualizar";
                persona.EventoString += NotificarCambio; //ASOCIO LA REFERENCIA AL METODO EN EL EVENTO EVNTO STRING.
            }
            if(txtNombre.Text != persona.Nombre)
            {
                persona.Nombre = txtNombre.Text;
            }
            if(txtApellido.Text != persona.Apellido)
            {
                persona.Apellido = txtApellido.Text;
            }

            lblNombreCompleto.Text = persona.Mostrar();

        }

        public void NotificarCambio(string cambio) //METODO AL QUE VOY A ASOCIAR AL EVENTO LANZADO. TIENE LA MISMA FIRMA QUE EL DELEGADO.
        {
            MessageBox.Show(cambio, "Notificacion de cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

    }
}
