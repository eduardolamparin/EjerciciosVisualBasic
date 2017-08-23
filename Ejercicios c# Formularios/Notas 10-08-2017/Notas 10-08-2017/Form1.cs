using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas_10_08_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2;
            if (Nota1 .Text== "" || Nota2 .Text =="")
            {
                MessageBox.Show("Error, debe ingresar datos");
            }
            else
	{
                nota1 =double .Parse (Nota1 .Text );
                nota2 =double .Parse (Nota2 .Text );
                if (nota1 >10.0 || nota2>10.0 )
	{
		 MessageBox .Show ("Error, las notas que ingrese deben estar entre 0 y 10" , "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error   );
	}
else
	{
                    if (nota1 <=2.0 && nota2 <=2.0)
	{
		 MessageBox .Show ("Reprobo la asignatura porque sus calificaciones fueron muy bajas, NO puede recuperar" , "REPROBO" , MessageBoxButtons.OK ,MessageBoxIcon .Asterisk );
	}
                    else
                        if (nota1 >= 9.0 && nota2 >=9.0)
                        {
                            MessageBox.Show("Aprobo la materia, NO tiene que presentar evalucacion final", "APROBO", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        }
                        else
                        {
                            MessageBox.Show("Usted tiene posibilidad de aprobar la materia, ingrese la tercera nota y Pulse el boton VERIFICAR", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
                            Nota3.Visible = true;
                            Evaluacion.Visible = true;

                            Nota1.ReadOnly = true;
                            Nota2.ReadOnly = true;
                            Reprobo.Enabled = false;
                        }

                      
                        
	
	}
	}




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Evaluacion_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, Promedio;
            nota1 = double.Parse(Nota1.Text);
            nota2 = double.Parse(Nota2.Text);
            if (Nota3 .Text =="")
            {
                MessageBox.Show("Error, debe ingresar un dato");
            }
            else
            {
                nota3 = double.Parse(Nota3.Text);
                if (nota3 >10.0)
                {
                    MessageBox.Show("Error, las notas que ingrese deben estar entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Promedio = (nota1 + nota2 + nota3) / 3;
                        if (Promedio >=7.0)
	{
        MessageBox.Show("Felicitaciones, Usted ha aprobado la materia con un promedio de: " + Promedio, " FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
                        else
                        {
                            if (Promedio <3.0)
                            {
                                MessageBox.Show("Usted es muy VAGO y reprobo la materia con un promedio de: " + Promedio, " LO SIENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            }
                            else
                            {
                                MessageBox.Show("Usted tiene la posibilidad de aprobar la materia presentando una EVALUACION, tiene un promedio de: " + Promedio + " Pero no es suficiente para aprobar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Ingrese la nota de la evaluacion para saber si definitivamente APROBO ó REPROBO la materia ");
                                NotaEvaluacion.Visible = true;
                                NotaFinal.Visible = true;
                                Nota3.ReadOnly = true;
                                Evaluacion.Enabled = false;
                            }
                        }
                }
            }
        }

        private void NotaFinal_Click(object sender, EventArgs e)
        {
            double Evaluacion;
            if (NotaEvaluacion .Text =="")
            {
                MessageBox.Show("Error, debe ingresar dato");
            }
            else
            {
                Evaluacion = double.Parse(NotaEvaluacion.Text);
                if (Evaluacion >10.0)
                {
                    MessageBox.Show("Error, las notas que ingrese deben estar entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Evaluacion <= 5.0)
                    {
                        MessageBox.Show("La evaluacion final no tuvo una nota lo suficientemente alta para que usted pudiera aprobar la materia, desafortunadamente REPROBO");
                    }
                    else
                    {
                      MessageBox .Show  ( "APROBO LA MATERIA", "Informacion",  MessageBoxButtons.OK , MessageBoxIcon.Information   );
                    }
                }
            }
        }

    }
}
