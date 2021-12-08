using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_5_zad_1_forms
{
    public partial class Form1 : Form
    {
        static double f(double x)
        {
            try
            {
                double e = 2.718281828;
                if (x == -1) throw new Exception();
                else return Math.Pow(e, (x - 1) * (x - 1) / x);
            }
            catch
            {
                throw;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                double a = 0, b = 0, h = 0;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                h = Convert.ToDouble(textBox3.Text);
                for (double i = a; i <= b; i += h)
                    try
                    {
                        str += "" + f(i) + ";";
                        textBox4.Text = Convert.ToString(str);

                    }
                    catch
                    {
                        MessageBox.Show("ошибка при:"+i);
                    }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ввода данных");
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
        }
    }
}
