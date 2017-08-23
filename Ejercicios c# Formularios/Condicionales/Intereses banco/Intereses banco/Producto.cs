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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            double po, pd,c,d1,d2;

            a = Convert.ToString(textBox1 .Text );
            c = double.Parse(textBox3.Text);
            po = double.Parse(textBox2.Text);

            if (c == 1)
            {
                MessageBox .Show ("Su descuento es del 10%");
                d1=(po *10)/100;

                pd=(po-d1);
                textBox4.Text = pd.ToString();
            }
            else
                if (c == 2)
                {
                    MessageBox.Show("Su descuento es del 20%");
                    d2 = (po * 20) / 100;
                    pd = (po - d2);
                    textBox4 .Text =pd .ToString ();
                }
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
