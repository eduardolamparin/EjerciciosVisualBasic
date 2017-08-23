using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ce, ve, t, d1,d2, d3, tp;
            ce = double.Parse(textBox1.Text);
            ve = double.Parse(textBox2.Text);
            t = (ce * ve);
            textBox3.Text = t.ToString();
           
            if (ce == 2)
            {
                d1 = (t * 10) / 100;
                textBox4.Text = d1.ToString();
                tp = (t - d1);
                textBox5.Text = tp.ToString();

            }
            else
            if (ce == 3)
            {
                d2 = (t * 15) / 100;
                textBox4.Text = d2.ToString();
                tp = (t - d2);
                textBox5.Text = tp.ToString();
            }
            else
            if (ce == 4)
            {
                d3 = (t * 20) / 100;
                textBox4.Text = d3.ToString();
                tp = (t - d3);
                textBox5.Text = tp.ToString();
            }
            else        
                if(ce>4)
            {
                MessageBox.Show("No puede comprar mas de 4 entradas");
            }
      
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
    }
}