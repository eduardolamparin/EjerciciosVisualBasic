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
namespace Nombre_Cedula_15_08_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nombre, cedula, carrera;
        private void button1_Click(object sender, EventArgs e)
        {
            nombre = Interaction.InputBox("Ingrese su nombre", " Mensaje", "", 50, 50);
            cedula  = Interaction.InputBox("Ingrese su documento", " Mensaje", "", 50, 50);
            carrera  = Interaction.InputBox("Ingrese su carrera", " Mensaje", "", 50, 50);
            MessageBox.Show("Su nombre es : " + nombre );
            MessageBox.Show(" Su documento es: " + cedula);
            MessageBox.Show(" Su carrera es: " + carrera);
        }
       
    }
}
