using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGUICalculator
{
    public partial class Form1 : Form
    {
        private CalculatorAction Calculator;
        private double X, Y;
        public Form1()
        {
            InitializeComponent();
        }
        private void ZamianaNaDouble()
        {
            try
            {
                X = Convert.ToDouble(textBox1.Text);
                Y = Convert.ToDouble(textBox2.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Podaj cyfry w obu polach");
            }
            
        }

        private void PokazWynik(double wynik, string operat)
        {
            labelwynik.Text = Convert.ToString(wynik);
            labeloperator.Text = operat;
            labelwynik.Visible = true;
            labeloperator.Visible = true;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            ZamianaNaDouble();
            PokazWynik(Calculator.Dodawanie(X,Y), "+");

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            ZamianaNaDouble();
            PokazWynik(Calculator.Odejmowanie(X, Y), "-");
        }

        private void buttondziel_Click(object sender, EventArgs e)
        {
            ZamianaNaDouble();
            if(Y == 0)
            {
                MessageBox.Show("Nie można dzielić przez 0!");
                return;
            }
            PokazWynik(Calculator.Dzielenie(X, Y), "/");
        }

        private void buttonmnoz_Click(object sender, EventArgs e)
        {
            ZamianaNaDouble();
            PokazWynik(Calculator.Mnozenie(X, Y), "*");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calculator = new CalculatorAction();
        }
    }
}
