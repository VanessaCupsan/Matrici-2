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
 
    public partial class Test : Form
    {
        int[] t = new int[10];
        int nIntrebare1, nintrebare3,nintrebare4,nintrebare7,nintrebare8;

        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            //pun scorurile pe 0
            for (int i = 0; i <= 9; i++)
                t[i] = 0;
            //generez intrebarea 1
            nIntrebare1 = r.Next(3, 200);
            Intrebare1.Text = "Variabila a memoreaza elementele unui tablou bidimensional cu " + nIntrebare1.ToString() + " linii si n" + nIntrebare1.ToString() + " coloane, numerotate de la 1 la " + nIntrebare1.ToString() + ".Un element aflat de diagonala secundara a tabloului poate fi accesat prin:";
            //generez intrebarea 2
            intrebare2.Text = "Într-un tablou bidimensional A, cu n linii şi n coloane, notăm cu Aij elementul aflat pe linia i şi coloana j (1≤i≤n, 1≤j≤n). Care este valoarea expresiei j+i dacă elementul Aij este situat pe diagonala secundară a tabloului A? ";
            //generez intrebarea 3
            nintrebare3 = r.Next(3, 200);
            intrebare3.Text = "În secvența următoare ,i,j și n sunt variabile întregi, iar a este o matrice pătratică formată din n linii și n coloane numerotate de la 0 la n-1. Care este suma elementelor de pe diagonala secundară din matricea a, în urma executării acestei secvențe, daca n= " + nintrebare3.ToString() + ".";
            //generez intrebarea 4
            nintrebare4 = r.Next(3, 100);
            intrebare4.Text = "    Variabilele i și j sunt de tip întreg, iar variabila m memorează un tablou bidimensional de n=" + nintrebare4.ToString() + " linii și n=" + nintrebare4.ToString() + " coloane, numerotate de la 0 la n-1, cu elemente numere întregi.";
            intrebare42.Text = "    O expresie C/C++ a cărei valoare este egală cu produsul dintre primul element de pe linia i și ultimul element de pe coloana j din acest tablou este: ";
            //generez intrebare 5
            intrebare5.Text = "    Într-un tablou bidimensional A, cu n linii și n coloane, notăm cu Aij elementul aflat pe linia i și coloana j ( 1 <= i <= n , 1 <= j <= n ). Care este valoarea expresiei j-i dacă elementul Aij este situat pe diagonala principală a tabloului A ?";
            //generez intrebarea 6
            intrebare6.Text = "    În secvența de mai jos, variabila a memorează un tablou bidimensional cu 20 de linii și 20 de coloane, numeroatate de la 1 la 20, cu elementele reale. Variabila p este reală, iar i este de tip întreg.";
            intrebare62.Text = "    Completați cu ”A” în căsuța din dreptul instrucțiunii care poate înlocui punctele de suspensie din secvența de program următoare astfel încât executarea acesteia să determine memorarea în variabila p a valorii produsului celor 40 de elemente aflate pe diagonala matricii.";
            //generez intrebarea 7;
            nintrebare7 = r.Next(3, 100);
            intrebare71.Text = "    În secvența de program următoare, variabila a memorează o matrice cu " + nintrebare7.ToString() + " linii și " + nintrebare7.ToString() + " coloane ( numerotate de la 1 la " + nintrebare7.ToString() + " ), cu elemente numere întregi, iar toate celelalte variabile sunt întregi.";
            intrebare72.Text = "    Ce valoare va avea elementul a[" + nintrebare7.ToString() + "][" + nintrebare7.ToString() + "] după executarea secvenței :";
            intrebare73.Text = " n = " + nintrebare7.ToString();
            //generez intrebare 8
            nintrebare8 = r.Next(3, 100);
            intrebare8.Text = "    Fiind dat un tablou bidimensional cu " + nintrebare8.ToString() + " linii și " + nintrebare8.ToString() + " coloane, câte elemente se găsesc strict deasupra diagonalei secundare a tabloului ?";
            //generez intrebarea 9
            intrebare91.Text = "    În secvența de program următoare, variabila a memorează elementele unui tablou bidimensional cu 5 linii ( numeroatate de la 1 la 5 ) și 5 coloane ( numerotate de la 1 la 5 ), iar celelalte variabile sunt de tip întreg.";
            intrebare92.Text = "    Ce valoare se va afișa în urma executării secvenței dacă se prelucrează tabloul bidimensional de mai jos ? Completați A în căsuța cu răspunsul corect și F în casuțele cu răspunsuri greșite. ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            int linie, coloana;
            try
            {
                linie = Int32.Parse(raspuns1Linie.Text); coloana = Int32.Parse(raspuns1Coloana.Text);
            }
            catch
            {
                linie = coloana = 0;
            }
            if (linie + coloana == nIntrebare1 + 1)
                t[1] = 1;
            else t[1] = 0;
            tabControl1.SelectTab(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void raspuns2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            int rezultat;
            try
            {
                rezultat = Int32.Parse(raspuns3.Text);
            }
            catch
            {
                rezultat = 0;
            }
            if (rezultat == nintrebare3*( nintrebare3 - 1 ) )
                t[3] = 1;
            else t[3] = 0;
            tabControl1.SelectTab(3);
        }

        private void raspuns1Coloana_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void intrebare4_Click(object sender, EventArgs e)
        {

        }

        private void intrebare42_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            int linie4, coloana4;
            try
            {
                linie4 = Int32.Parse(raspuns4Linie.Text); coloana4 = Int32.Parse(raspuns4Coloana.Text);
            }
            catch
            {
                linie4 = coloana4 = 0;
            }
            if ( linie4 == 0 && coloana4 == nintrebare4 - 1 )
                t[4] = 1;
            else t[4] = 0;
            tabControl1.SelectTab(4);
        }

        private void intrebare2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            int rezultat5;
            try
            {
                rezultat5 = Int32.Parse(raspuns5.Text);
            }
            catch
            {
                rezultat5 = 2;
            }
            if (rezultat5 == 0)
                t[5] = 1;
            else t[5] = 0;
            tabControl1.SelectTab(5);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            int rezultat8;
            try
            {
                rezultat8 = Int32.Parse(raspuns8.Text);
            }
            catch
            {
                rezultat8 = 0;
            }
            if (rezultat8 == ((nintrebare8-1)*nintrebare8)/2)
                t[8] = 1;
            else t[8] = 0;
            tabControl1.SelectTab(8);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                t[9] = 1;
            else t[9] = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            int rezultat7;
            try
            {
                rezultat7 = Int32.Parse(raspuns7.Text);
            }
            catch
            {
                rezultat7 = 0;
            }
            if (rezultat7 == nintrebare7*2-1)
                t[7] = 1;
            else t[7] = 0;
            tabControl1.SelectTab(7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (raspuns61.Text == "F" && raspuns62.Text == "F" && raspuns63.Text == "F" && raspuns64.Text=="A")
                t[6] = 1;
            else t[6] = 0;
            tabControl1.SelectTab(6);
        }

        private void Raspuns1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (raspuns2.Text == "n+1" || raspuns2.Text == "n + 1" || raspuns2.Text == "1+n")
                t[2] = 1;
            else t[2] = 0;
            tabControl1.SelectTab(2);
        }
    }
}
