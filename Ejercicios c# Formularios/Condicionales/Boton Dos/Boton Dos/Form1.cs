using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boton_Dos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = button3.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)//Si el visto bueno esta activo+

                pictureBox1.Hide();//visualiza la imagen con show "mostrar imagen"
            else
                pictureBox1.Show();
        }
    }
}
