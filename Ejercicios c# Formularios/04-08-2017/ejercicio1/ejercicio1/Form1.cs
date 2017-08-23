using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,suma;
            suma = 0;
            for (a = 1; a <=10; a++)
            {
                MessageBox.Show("Los numero son: " + a);
                suma = suma + a;
            }
           
            MessageBox.Show("La suma es: " + suma);
        }
    }
}
