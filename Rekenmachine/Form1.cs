using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        public double waarde1;
        public double waarde2;
        public List<double> waarden = new List<double>();
        public List<string> operators = new List<string>();
        public bool plus;
        public bool min;
        public bool keer;
        public bool delen;
        public bool mod;
        public bool sqrt;
        public bool pow;
        public double pi = Math.PI;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            saveValue();
            saveOperator("plus");
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            saveValue();
            saveOperator("min");
        }

        private void button_keer_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            saveValue();
            saveOperator("keer");
        }
        private void button_delen_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            saveValue();
            saveOperator("delen");
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            saveValue();
            mod = true;
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            saveValue();
            sqrt = true;
            //textBox1.Text = Convert.ToString(Math.Sqrt(waarde1));
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            saveValue();
            pow = true;
        }

        private void button_pi_Click(object sender, EventArgs e)
        {
            waarde1 = pi;
            textBox1.Text += waarde1;
        }
        private void saveValue()
        {
            waarden.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
        }

        private void saveOperator(String oper)
        {
            operators.Add(oper);
            textBox1.Clear();
        }

        private void button_is_Click(object sender, EventArgs e)
        {
            saveValue();
            double[] aWaarden = waarden.ToArray();
            String[] aOperators = operators.ToArray();

            double totaal = aWaarden[0];
            for (int i = 1; i < aWaarden.Length; i++)
            {
                Console.WriteLine(aOperators[i-1]);
                if (aOperators[i-1] == "plus")
                {
                    totaal = totaal + aWaarden[i];
                }
                else if (aOperators[i-1] == "min")
                {
                    totaal = totaal - aWaarden[i];
                }
                else if (aOperators[i - 1] == "keer")
                {
                    totaal = totaal * aWaarden[i];
                }
                else if (aOperators[i - 1] == "delen")
                {
                    totaal = totaal / aWaarden[i];
                }
                textBox2.Clear();
            }

            textBox1.Text = Convert.ToString(totaal);

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            waarden.Clear();
            operators.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }
    }   
}
