using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarBiblioteca();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefrescarBiblioteca()
        {
            //datagridview levanta un objeto y muestra las propiedades publicas que tiene.
            dtgvBiblioteca.DataSource = JuegoDAO.Leer(); // le cargo los datos a leer.
            dtgvBiblioteca.Refresh(); // refrescamos.
            dtgvBiblioteca.Update(); // actualizamos.
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBiblioteca.SelectedRows.Count > 0) //me fijo que tengo algo seleccionado.
                {
                    //recupero el objeto biblioteca.    Casteo a biblioteca el currentrow.databounditem del datagridview
                    Biblioteca.Biblioteca biblioteca = (Biblioteca.Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                    JuegoDAO.Eliminar(biblioteca.CodigoJuego);
                    RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAlta frmAlta = new FrmAlta();

                if (frmAlta.ShowDialog() == DialogResult.OK)
                {
                    RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgvBiblioteca.SelectedRows.Count > 0)//me fijo que tengo algo seleccionado.
                {
                    //recupero el objeto biblioteca.    Casteo a biblioteca el currentrow.databounditem del datagridview
                    Biblioteca.Biblioteca biblioteca = (Biblioteca.Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                    FrmAlta frmAlta = new FrmAlta(biblioteca.CodigoJuego);

                    if (frmAlta.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarBiblioteca();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
