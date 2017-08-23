using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aleatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numero.Text == adivinar.Text)
            {
                MessageBox.Show("¡Felicidades, adivino el numero en hora buena!");
            }
            else
                MessageBox.Show("Lo siento, su numero es correcto, intentelo de nuevo ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random n = new Random();
            int numero = n.Next(1, 10);
            adivinar.Text = Convert.ToString(numero);
        }
    }
}
