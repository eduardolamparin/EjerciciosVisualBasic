using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altura_persona
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

            if (a <= 150) 
            {
                MessageBox.Show("Persona de altura baja");
            }
            else
                if (a >= 151 && a <= 170)
                {
                    MessageBox.Show("Persona de altura media");
                }
                else
                {
                    MessageBox.Show("Persona alta ");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
