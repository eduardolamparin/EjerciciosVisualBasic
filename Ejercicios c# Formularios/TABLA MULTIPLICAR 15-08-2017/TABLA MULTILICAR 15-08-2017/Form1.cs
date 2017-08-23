using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace TABLA_MULTIPLICAR_15_08_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero;
        double resultadoa, resultadob, resultadoc, resultadod, resultadoe, resultadof, resultadog, resultadoh, resultadoi, resultadoj, resultadok,a;
        private void button1_Click(object sender, EventArgs e)
        {
            numero  = Interaction.InputBox("Ingrese numero", " Mensaje", "", 50, 50);
            if (Convert.ToDouble(numero ) >= 0 && Convert.ToDouble(numero) <= 10)
            {
                a = double.Parse(numero);
                
               
            }
            resultadoa = (a * 0);
            resultadob= (a * 1);
            resultadoc= (a * 2);
            resultadod= (a * 3);
            resultadoe= (a * 4);
            resultadof= (a * 5);
            resultadog= (a * 6);
            resultadoh= (a * 7);
            resultadoi= (a * 8);
            resultadoj= (a * 9);
            resultadok = (a * 10);

            MessageBox.Show("La multiplicacion es: " + resultadoa);
            MessageBox.Show("La multiplicacion es: " + resultadob);
            MessageBox.Show("La multiplicacion es: " + resultadoc);
            MessageBox.Show("La multiplicacion es: " + resultadod);
            MessageBox.Show("La multiplicacion es: " + resultadoe);
            MessageBox.Show("La multiplicacion es: " + resultadof);
            MessageBox.Show("La multiplicacion es: " + resultadog);
            MessageBox.Show("La multiplicacion es: " + resultadoh);
            MessageBox.Show("La multiplicacion es: " + resultadoi);
            MessageBox.Show("La multiplicacion es: " + resultadoj);
            MessageBox.Show("La multiplicacion es: " + resultadok);
           








        }
    }
}
