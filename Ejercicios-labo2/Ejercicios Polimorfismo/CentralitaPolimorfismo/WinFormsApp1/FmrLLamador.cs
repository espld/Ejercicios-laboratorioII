using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.Provincial;

namespace WinFormsApp1
{
    public partial class FmrLLamador : Form
    {
        private Centralita centralita;
        Llamada llamada;

        public FmrLLamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        //propiedades
        public Centralita Centralita
        {
            get { return this.centralita; }
        }

        private void FmrLLamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(EFranja));
            // Lectura
            EFranja franjas;
            Enum.TryParse<EFranja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";

            if (cmbFranja.Enabled == false)
            {
                cmbFranja.Enabled = true;
                cmbFranja.SelectedIndex = 0;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text.StartsWith('#'))
            {
                this.cmbFranja.Enabled = true;
            }
            else
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void txtNroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnUno.Text);
        }

        private void CargarNumero(string digito)
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }

            this.txtNroDestino.Text += digito;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnDos.Text);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnTres.Text);
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnCuatro.Text);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnCinco.Text);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnSeis.Text);
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnSiete.Text);
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnOcho.Text);

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnNueve.Text);
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnAsterisco.Text);
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnCero.Text);
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnNumeral.Text);
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();

            float auxDuracion = rdm.Next(1, 50);

            if (this.txtNroDestino.Text[0] == '#')
            {
                llamada = new Provincial(this.txtNroOrigen.Text,(Provincial.EFranja)this.cmbFranja.SelectedItem,auxDuracion,this.txtNroDestino.Text);
            }
            else
            {
                float costo = (float)rdm.Next(1, 100);

                llamada = new Local(this.txtNroOrigen.Text, auxDuracion, this.txtNroDestino.Text, costo);
            }

            centralita += llamada;

        }
    }
}
