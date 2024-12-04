using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmrPrincipal
{
    public partial class fmrSaludo : Form
    {
        public fmrSaludo(string titulo, string mensaje)
        {
            InitializeComponent();
            this.lblTitulo.Text = titulo;
            this.lblNombre.Text = mensaje;
        }
    }
}
