using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosAleatorios_JP
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            G1_NumerosAleatorios juego1 = new G1_NumerosAleatorios();
            juego1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            G2_PiedraPapeTijera juego2 = new G2_PiedraPapeTijera();
            juego2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
