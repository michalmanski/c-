using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{


    public partial class Form1 : Form
    {
        string dzialanie;
        int liczba = 0;
        int liczba2 = 0;
        double wynik = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Przycisk_Klik(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + ((sender as Button).Text);
            liczba = Int32.Parse(textBox1.Text);
            //label1.Text = label1.Text + ((sender as Button).Text);
            //liczba = Int32.Parse(label1.Text);
           // textBox1.Text = Convert.ToString(liczba);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {

                case("+"):
                    wynik = wynik + liczba;
                    textBox1.Text = "";
                    textBox1.Text = Convert.ToString(wynik);
                    // label1.Text = Convert.ToString(wynik);
                    //wynik = liczba2;
                    break;

                case ("-"):
                    wynik = wynik - liczba;
                    textBox1.Text = "";
                    textBox1.Text = Convert.ToString(wynik);
                    wynik = liczba2;
                    break;

                case ("*"):
                    wynik = wynik * liczba;
                    textBox1.Text = "";
                    textBox1.Text = Convert.ToString(wynik);
                    wynik = liczba2;
                    break;

                case ("/"):
                  if (liczba != 0)
                   
                    {
                        wynik = wynik / liczba;
                        textBox1.Text = "";
                        textBox1.Text = Convert.ToString(wynik);
                        wynik = liczba2;
                    }
                    else  textBox1.Text = "Nie można dzielić przez 0";
                    break;

                    

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wynik = 0;
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            liczba2 = liczba;
            wynik = liczba2;
            dzialanie = "+";
            textBox1.Text = "";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            liczba2 = liczba;
            wynik = liczba2;
            dzialanie = "/";
            textBox1.Text = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            liczba2 = liczba;
            wynik = liczba2;
            dzialanie = "*";
            textBox1.Text = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            liczba2 = liczba;
            wynik = liczba2;
            dzialanie = "-";
            textBox1.Text = "";
        }
    }
}
