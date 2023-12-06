using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double a, b, c;
        bool x = true, y = true, z = true;
        char v;
        public Form1()
        {
            InitializeComponent();
        }


        void TXT(char c)
        {
            if (!y)
            {
                textBox1.Clear(); y = true;
            }
            if (textBox1.Text != "")
                if (textBox1.Text == "0")
                    textBox1.Text = c.ToString();
                else
                    textBox1.Text += c.ToString();
            else
                textBox1.Text = c.ToString();
        }
        double Viches(char c)
        {
            if (x) { a = Convert.ToDouble(textBox1.Text); x = false; y = false; }
            else
            if (y)
            {
                y = false;
                b = Convert.ToDouble(textBox1.Text);
                switch (c)
                {
                    case '+': a += b; break;
                    case '-': a -= b; break;
                    case '*': a *= b; break;
                    case '/': a /= b; break;
                }
            }
            return a;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //цифры
        private void button1_Click_1(object sender, EventArgs e)
        {
            TXT('0');
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            TXT('1');
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            TXT('2');
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TXT('3');
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            TXT('4');
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            TXT('5');
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            TXT('6');
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            TXT('7');
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            TXT('8');
        }
        private void button10_Click(object sender, EventArgs e)
        {
            TXT('9');
        }

        //операции
        private void button25_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (1 / a).ToString();

        }
        private void button19_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Pow(a, 1.0 / 2).ToString();

        }
        private void button24_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (a * a).ToString();

        }
        private void button28_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (a * a * a).ToString();
        }
        private void button27_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Pow(a, 1.0 / 3).ToString();

        }
        private void button35_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Pow(10, x).ToString();
        }
        private void button36_Click_1(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox1.Text);
            textBox1.Text = Math.Pow(x, y).ToString();
        }
        private void button37_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Abs(x).ToString();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = (x/100).ToString();
        }


        //кнопки
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.IndexOf(',') < 0)
            {
                textBox1.Text += ".";
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            char c = textBox1.Text[0];
            if (c == '-')
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else
                textBox1.Text = '-' + textBox1.Text;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = Viches(v).ToString();
            v = ' ';
        }
        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //+, -, *, /
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = Viches(v).ToString();
            v = '+';

        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Viches(v).ToString();
            v = '-';
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Viches(v).ToString();
            v = '*';
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Viches(v).ToString();
            v = '/';
        }

        //тригонометрия
        private void button29_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sin(x * Math.PI / 180).ToString();
        }
        private void button30_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Cos(x * Math.PI / 180).ToString();
        }
        private void button31_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Tan(x * Math.PI / 180).ToString();
        }
        private void button32_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = Math.Cos(x * Math.PI / 180) / Math.Sin(x * Math.PI / 180);
            textBox1.Text = y.ToString();
        }
        private void button45_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Asin(x).ToString();
        }
        private void button44_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Acos(x).ToString();
        }
        private void button43_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Atan(x).ToString();
        }
        private void button42_Click(object sender, EventArgs e)
        {
            
        }

        //фактариал
        private void button39_Click_1(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double fact(double k)
            {
                if (k == 0) return 1;
                else
                    return k * fact(k - 1);
            }
            textBox1.Text = fact(x).ToString();
        }

        


        //логарифмы
        private void button33_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Log(x).ToString();
        }
        private void button34_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Log10(x).ToString();
        }

        //постоянные
        private void button40_Click(object sender, EventArgs e)
        {
            double x = Math.PI;
            textBox1.Text = x.ToString();
        }
        private void button41_Click(object sender, EventArgs e)
        {
            double x = Math.E;
            textBox1.Text = x.ToString();
        }


    }
}


