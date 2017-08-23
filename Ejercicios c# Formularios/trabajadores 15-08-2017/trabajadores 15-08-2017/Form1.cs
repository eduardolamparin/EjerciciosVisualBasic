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
namespace trabajadores_15_08_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string nombre;
        string sueldos;
        string area;
        private void button1_Click(object sender, EventArgs e)
        {
            double sumatoria=0;

            for (int i=1 ; i<=5;i++)
            {
                nombre = Interaction.InputBox("Ingrese Nombre" + i);
                sueldos  = Interaction.InputBox("Ingrese Sueldo" + i);
                area  = Interaction.InputBox("Ingrese Area" + i);
                double a = Convert.ToDouble(sueldos );

                sumatoria = sumatoria + a;

            }
            MessageBox.Show("La sumatoria de los sueldos es: " + sumatoria );

            
          

        }
    }
}
