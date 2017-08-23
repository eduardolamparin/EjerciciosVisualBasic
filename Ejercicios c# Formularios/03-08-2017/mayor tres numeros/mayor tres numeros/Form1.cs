using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_tres_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            if (a > b && a > c && b>c)
            {
                MessageBox.Show("El numero mayor es: " + a + " El numero menor es: " + c );
            }
            else
                if (a > b && a > c && c>b)
                {
                    MessageBox.Show("El numero mayor es: " + a + " el numero menor es: " + b);
                }
                else
                    if (b > a && b > c && a>c)
                    {
                        MessageBox.Show("El numero mayor es: " + b + " el numero menor es: " + c);
                    }
                    else
                        if (b > a && b > c && c > a)
                        {
                            MessageBox.Show("El numero mayor es: " + b + " el numero menor es: " + a);
                        }
                        else
                            if (c > a && c > b && a > b)
                            {
                                MessageBox.Show("El numero mayor es: " + c + " el numero menor es: " + b);
                            }
                            else
                                if (c > a && c > b && b > a)
                                {
                                    MessageBox.Show("El numero mayor es: " + c + " el numero menor es: " + a);
                                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
