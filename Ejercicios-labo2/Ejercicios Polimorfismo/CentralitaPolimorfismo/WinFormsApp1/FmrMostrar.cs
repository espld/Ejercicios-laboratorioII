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

namespace WinFormsApp1
{
    public partial class FmrMostrar : Form
    {

        private Llamada.ETipoLlamada tipo;

        public FmrMostrar(Centralita centralita)
        {
            InitializeComponent();

            if(tipo == Llamada.ETipoLlamada.Local)
            {
                rtbMostrar.Text = centralita.
            }
        }
    }
}
