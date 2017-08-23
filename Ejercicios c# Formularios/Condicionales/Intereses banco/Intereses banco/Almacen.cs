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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v, d, t;
            v = double.Parse(textBox1.Text);

            if (v >= 100000)
            {
                MessageBox.Show("su descuento es del 20%");
                d = (v * 20) / 100;
                MessageBox.Show("El valor de su descuento es:" + d);
                t = (v - d);
                textBox2.Text = t.ToString();
            }
            else
                MessageBox .Show ("Usted no tiene descuento");
            }
        
           
    }
}
