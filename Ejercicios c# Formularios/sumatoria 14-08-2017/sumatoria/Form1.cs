using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic ;

namespace sumatoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double m;
        
       string numeros;
        long  i = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            double Sumatoria = 0;
            while (i < 30)
            {
                numeros = Interaction.InputBox("Ingrese el numero", "Mensaje", "", 50, 50);
                m = Convert.ToDouble (numeros);
                
                {
                    Sumatoria = Sumatoria  + m;
                    

                                        
                }

                i = i + 1;
                                          
            }
            MessageBox.Show("La sumatoria de los primeros 30 numeros es :"+Sumatoria );





        }
    }
}
