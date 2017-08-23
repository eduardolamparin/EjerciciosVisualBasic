using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked == true)
            {
                Text = Text + "Chrome";
            }
            if (checkBox2.Checked == true)
            {
                Text = Text + "Mozilla";
            }
            if (checkBox3.Checked == true)
            {
                Text = Text + "Explorer";
            }
        }
    }
}
