using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intereses_banco
{
    public partial class Calificaciones : Form
    {
        public Calificaciones()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p, s, t, pro;
            p = double.Parse(textBox1.Text);
            s = double.Parse(textBox2.Text);
            t = double.Parse(textBox3.Text);
            pro = (p + s + t) / 3;
            textBox4.Text = pro.ToString();

            if (pro >= 70)
            {
                MessageBox.Show("¡Felicitaciones! Usted aprobó");
            }
            else 
                MessageBox .Show ("¡Lo siento! Usted reprobó");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
