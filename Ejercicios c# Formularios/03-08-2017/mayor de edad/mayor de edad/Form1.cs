using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_de_edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;

            a = double.Parse(textBox1.Text);
            if (a < 18) 
            {
                MessageBox.Show("Usted es menor de edad");
            }
            else
                {
                    MessageBox.Show ("Usted es mayor de edad");
                }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
