using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            nupPrecio.Maximum = 1000;
            //cmbUsuarios.Hide();
            //lblUsuarios.Text = string.Empty;
            this.codigoJuego = codigoJuego; //tengo que inicializar el codigo asi no rompe cuando apreto modificar.
            PintarForm();
        }

        private void PintarForm() //encargado de cargar las propiedades - codigojuego lo recibimos del otro constructor frmAlta
        {
            Juego juego = JuegoDAO.LeerPorId(codigoJuego);

            txtGenero.Text = juego.Genero;
            txtNombre.Text = juego.Nombre;
            nupPrecio.Value = (decimal)juego.Precio; //hay que castear a decimal xq nup recibe un decimal.
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            try
            {
                cmbUsuarios.DataSource = UsuarioDAO.Leer(); //el datasource muestra en pantalla un objeto en to string,
                                                            //x eso en la clase Usuario usuario tengo un ToString que retorna username.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text != "Modificar") //si entra acá es para guardar un nuevo juego.
                {
                    //creo un nuevo juego con los datos del altaform
                    Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text,
                    ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                    JuegoDAO.Guardar(nuevoJuego); //llamo a juegoDAO.guardar y le paso el juego nuevo.
                }
                else//si entra acá es para modificar
                {
                    Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text,this.codigoJuego,
                   ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                    JuegoDAO.Modificar(nuevoJuego);//lamo a juegoDAO.modificar y le paso el juego con los datos a modificar.
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
