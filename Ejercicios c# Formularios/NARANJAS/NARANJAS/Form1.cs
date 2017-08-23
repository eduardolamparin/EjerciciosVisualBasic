using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NARANJAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k, p, d, t,pt;

            k = double.Parse(textBox1.Text);
            p = double.Parse(textBox2.Text);
           
          
           
            if(k>=10)
            {
                MessageBox.Show("Tiene un descuent del 15%");


                pt = (p * k);
                d = (pt * 15) / 100;
                t = (pt - d);
                textBox3.Text = d.ToString();
                textBox4.Text = t.ToString();
                textBox5.Text = pt.ToString();
            }
            else
            {
                MessageBox.Show("No aplica descuento");
                pt = (p * k);
                textBox4.Text = pt.ToString();
            }

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
    