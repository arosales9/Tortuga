using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga
{
    public partial class Form1 : Form
    {
        TortugaTablero TTablero = new TortugaTablero();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            TTablero._pluma1 = -1;
        }

        private void btnArriva_Click(object sender, EventArgs e)
        {
            TTablero._pluma1 = 1;
        }

        private void btnGiraDerecha_Click(object sender, EventArgs e)
        {
            TTablero.GirarDerecha();
        }

        private void btnGiraIzquierda_Click(object sender, EventArgs e)
        {
            TTablero.GirarIzquierda();
        }

        private void btnAvanza_Click(object sender, EventArgs e)
        {
            TTablero.Avanza(Convert.ToInt32(txtAvanzar.Text));
        }

        private void btnMostrarArreglo_Click(object sender, EventArgs e)
        {
            txtTablero.Clear();
            TTablero.Imprime();
            txtTablero.Text = TTablero.ToString();
        }
    }
}
