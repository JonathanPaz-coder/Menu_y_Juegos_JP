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
    public partial class G2_PiedraPapeTijera : Form
    {
        Random random = new Random();
        int decision_PC;
        const int piedra = 1;
        const int papel = 2;
        const int tijera = 3;

        //Numero 1 para Piedra
        //Numero 2 para Papel
        //Numero 3 para Tijeras
        public G2_PiedraPapeTijera()
        {
            InitializeComponent();
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            decision_PC = random.Next(1, 4);
            if(decision_PC == piedra)
            {
                MessageBox.Show("Has Empatado");
            }
            else
            {
                if (decision_PC == papel)
                {
                    MessageBox.Show("Has Perdido");
                }
                else
                {
                    if (decision_PC == tijera)
                    {
                        MessageBox.Show("Has Ganado");
                    }
                }
            }
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            decision_PC = random.Next(1, 4);
            if (decision_PC == papel)
            {
                MessageBox.Show("Has Empatado");
            }
            else
            {
                if (decision_PC == tijera)
                {
                    MessageBox.Show("Has Perdido");
                }
                else
                {
                    if (decision_PC == piedra)
                    {
                        MessageBox.Show("Has Ganado");
                    }
                }
            }
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            decision_PC = random.Next(1, 4);
            if (decision_PC == tijera)
            {
                MessageBox.Show("Has Empatado");
            }
            else
            {
                if (decision_PC == piedra)
                {
                    MessageBox.Show("Has Perdido");
                }
                else
                {
                    if (decision_PC == papel)
                    {
                        MessageBox.Show("Has Ganado");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
