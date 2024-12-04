using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;

        public FrmCartelera()
        {
            InitializeComponent();
        }

        static FrmCartelera()
        {
            rutaConfiguracion = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "configuracion.json");
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private Color ElegirColor(Color colorActual)
        {
            colorDialog.Color = colorActual;
            colorDialog.ShowDialog();
            return colorDialog.Color;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            this.pnlCartel.BackColor = this.ElegirColor(pnlCartel.BackColor);
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            this.lblTitulo.ForeColor = this.ElegirColor(lblTitulo.ForeColor);
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            this.lblMensaje.ForeColor = this.ElegirColor(lblMensaje.ForeColor);
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            this.ImportarConfiguracion(rutaConfiguracion);
        }
        private void ImportarConfiguracion(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string cartelJson = File.ReadAllText(path);
                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(cartelJson);

                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuración no se encuentra en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }
        private void MostrarMensajeDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(ex.Message);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            this.GuardarConfiguracion();
        }

        private void GuardarConfiguracion()
        {
            try
            {
                Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
                Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
                Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);

                string cartelJson = JsonSerializer.Serialize(cartel);

                File.WriteAllText(rutaConfiguracion, cartelJson);
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files(*.json)|*.json";
            openFileDialog.ShowDialog();
            ImportarConfiguracion(openFileDialog.FileName);
        }

        private void EliminarConfiguracion()
        {
            try
            {
                if (File.Exists(rutaConfiguracion))
                {
                    File.Delete(rutaConfiguracion);
                }

                txtTitulo.Text = "Título";
                lblTitulo.ForeColor = Control.DefaultForeColor;

                rtxtMensaje.Text = "Mensaje";
                lblMensaje.ForeColor = Control.DefaultForeColor;

                pnlCartel.BackColor = Control.DefaultBackColor;
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la configuración?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                EliminarConfiguracion();
            }
        }
    }
}
