using Biblioteca;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int kilometros;
            int litros;

            try
            {

                if(string.IsNullOrEmpty(this.txtKilometros.Text) || string.IsNullOrEmpty(this.txtLitros.Text))
                {
                    throw new ParametrosVaciosException();
                }

                kilometros = int.Parse(this.txtKilometros.Text);
                litros = int.Parse(this.txtLitros.Text);

                rtbVista.Text = Calculador.Calcular(kilometros,litros).ToString();

            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Ingresar números válidos","ERROR");
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero","ERROR");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}
