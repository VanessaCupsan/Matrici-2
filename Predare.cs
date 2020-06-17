using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Matrici_2
{
    public partial class Predare : Form
    {
        int crt;
        string[] fisiere;
        public Predare()
        {
            InitializeComponent();
        }

        private void Predare_Load(object sender, EventArgs e)
        {
            fisiere = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\poze\poze.txt");
            crt = 0;
            poza.Image=Image.FromFile(Directory.GetCurrentDirectory() + @"\poze\"+fisiere[crt]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (crt > 0)
                crt--;
            poza.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\poze\" + fisiere[crt]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (crt < fisiere.Length-1)
                crt++;
            poza.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\poze\" + fisiere[crt]);
        }

        private void poza_Click(object sender, EventArgs e)
        {

        }
    }
}
