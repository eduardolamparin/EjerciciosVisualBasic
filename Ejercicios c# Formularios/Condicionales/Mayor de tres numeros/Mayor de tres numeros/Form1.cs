using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayor_de_tres_numeros
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
            if (textBox1.Text == "")
            {
                MessageBox.Show("Error ingrese un valor");
            }
            else
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);

                if (a > b && a > c && b > c)
                {
                    MessageBox .Show (("El numero mayor es: ") + a + ( " El numero menor es: ") +c);
                }

                if (a > b && a > c && c > b)
                {
                    MessageBox.Show(("El numero mayor es: ") + a + ( " El numero menor es: ") + b);
                }

                if (b > a && b > c && a > c )
                {
                    MessageBox.Show(("El numero mayor es: ") + b + ( " El numero menor es: ") + c);
                }

                if (b > a && b > c && a > c)
                {
                    MessageBox.Show(("El numero mayor es: ") + b + ( " El numero menor es: ") + a);
                }


                if (c > a && c > b && b > a)
                {
                    MessageBox.Show(("El numero mayor es: ") + c + ( " El numero menor es: ") + a);
                }


                if (c > a && c > b && a > b)
                {
                    MessageBox.Show(("El numero mayor es: ") + c + ( " El numero menor es: ") + b);
                }












            }
        }
    }
}
