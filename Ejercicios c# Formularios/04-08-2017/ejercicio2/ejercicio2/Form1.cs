using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double he, hs, th, tp;
            he=double .Parse (textBox1 .Text );
            hs = double.Parse(textBox2.Text);

            th = (hs - he);
            textBox3.Text = th.ToString();
            if (th <= 1)
            {
                MessageBox.Show("Total a pagar 1000");
            }
            else
                if (th > 1)
                {
                    tp = ((th-1) * 600 + 1000);
                    MessageBox.Show("Total a pagar: " + tp);
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
