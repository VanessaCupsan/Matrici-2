using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrici_2
{
    public partial class Practice : Form
    {
        public Practice()
        {
            InitializeComponent();
        }

        private void verifica_Click(object sender, EventArgs e)
        {
            
            if ( Int32.Parse( Raspuns1.Text) == 5)
                MessageBox.Show("raspuns corect");
            else MessageBox.Show("Raspunsul corect este 5 si se obtine pe linia 4, coloana 5, deoarece 4%5 + 5%4 = 5");
        }

        private void Intrebari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Raspuns1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Raspuns2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Raspuns2.Text) == 0)
                MessageBox.Show("Raspuns corect");
            else MessageBox.Show("Raspunsul corect este 0, deorece elementele de pe diagonala secundara au coordonatele [1][5], [2][4], [3][3], [4][2], [5][1]");
        }

        private void Raspuns3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Raspuns3.Text) == 68)
                MessageBox.Show("Raspuns corect");
            else MessageBox.Show("Raspunsul corect este 68, deorece elementele de pe diagonala principala au valorile 2, 12, 22 si 32 ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Raspuns4.Text) == 65)
                MessageBox.Show("Raspuns corect");
            else MessageBox.Show("Raspunsul corect este 65, deorece elementele de pe diagonala secundara au valorile 5, 9, 13, 17 si 21 ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Raspuns5.Text) == 5)
                MessageBox.Show("Raspuns corect");
            else MessageBox.Show("Raspunsul corect este 5, deorece elementele impare de sub diagonala secundara au valorile 5, 9, 15 si 7 ");
        }
    }
}
