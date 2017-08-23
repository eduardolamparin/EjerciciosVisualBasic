using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PALINDROME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A = "", B = "";
            string C;
            int R = 0;
            int i = 0;
           

            A = Convert.ToString(textBox1.Text);

            R = A.Length;

            for ( i=R-1; i>=0; i--)
            {
                C = A.Substring(i, 1);

                B = B + C;

            }
            MessageBox.Show("palabra invertida     "+B);

            if (A.Equals(B))
            {
                MessageBox.Show("es palindrome");

            }
            else
            {
                MessageBox.Show("no es palindrome");
            }
        }
    }
}
