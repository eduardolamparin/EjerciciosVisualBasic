using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cONSTRUCTORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Realice un algoritmo para que la empresa constructoratecnovivir que le permirta calcular e imprimir la nomina para su cancelacion 
            // a un total de 50 obreros a quienes deben cancelar por horas trabajadas la hora trabajada se pauto a 10 mil pesos
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double h, th, ne, x;


            ne = double.Parse(textBox3.Text);
            for (x = 0; x <ne; x++) 
            {
                
                h = double.Parse(textBox2.Text);
                th = (h * 10000);
                MessageBox.Show("El total a pagar es de: " + th  );
            }
        }
    }
}
