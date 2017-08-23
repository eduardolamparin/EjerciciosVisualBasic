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
namespace Muestreo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Una persona debe realizar un muestreo con 50 personas para determinar el promedio de peso de los niños, jovenes, adultos y viejos
            // que existen en su zona habitacional. Se determinan las categorias en base a la siguiente tabla:
            // niños 0-12
            // jovenes 13-29
            // adultos 30-59
            // viejos 60 en adelante

    
        }
        long i = 1;
       string  peso;
       double  promedio=0;
        private void button1_Click(object sender, EventArgs e)
        {
            while (i <=5)
            {
                peso = Interaction.InputBox("Ingrese su peso:", "Promedio", "", 50, 50);
                if (Convert.ToDouble(peso) >= 0)
                {
                    peso = peso + 1;
                }
                i = i + 1;
                {
                    promedio = (peso / i);
                }

           
            }
        }
    }
}
