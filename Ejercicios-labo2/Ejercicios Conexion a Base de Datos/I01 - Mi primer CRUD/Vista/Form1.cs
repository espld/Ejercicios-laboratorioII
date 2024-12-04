using Biblioteca;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<Persona> listaPersona = PersonaDAO.Leer();
            lstPersonas.Items.Clear();

            foreach (var item in listaPersona)
            {
                lstPersonas.Items.Add(item);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona personaSeleccionada = lstPersonas.SelectedItem as Persona;
            personaSeleccionada.Nombre = txtNombre.Text;
            personaSeleccionada.Apellido = txtApellido.Text;
            PersonaDAO.Modificar(personaSeleccionada);
            txtNombre.Clear();
            txtApellido.Clear();
            lstPersonas.Items.Clear();
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona personaSeleccionada = lstPersonas.SelectedItem as Persona;

            if (personaSeleccionada != null)
            {
                txtNombre.Text = personaSeleccionada.Nombre;
                txtApellido.Text = personaSeleccionada.Apellido;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea agregar?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Persona personaNueva = new Persona(txtNombre.Text, txtApellido.Text);
                PersonaDAO.Guardar(personaNueva);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea eliminar? No hay vuelta atrás", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Persona personaSeleccionada = lstPersonas.SelectedItem as Persona;
                PersonaDAO.Eliminar(personaSeleccionada.Id);
            }
        }
    }
}
