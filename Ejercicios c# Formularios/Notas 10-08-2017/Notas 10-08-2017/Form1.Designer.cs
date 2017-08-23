namespace Notas_10_08_2017
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nota1 = new System.Windows.Forms.TextBox();
            this.Nota2 = new System.Windows.Forms.TextBox();
            this.Reprobo = new System.Windows.Forms.Button();
            this.Nota3 = new System.Windows.Forms.TextBox();
            this.NotaEvaluacion = new System.Windows.Forms.TextBox();
            this.Evaluacion = new System.Windows.Forms.Button();
            this.NotaFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nota1
            // 
            this.Nota1.Location = new System.Drawing.Point(45, 44);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(100, 20);
            this.Nota1.TabIndex = 0;
            // 
            // Nota2
            // 
            this.Nota2.Location = new System.Drawing.Point(45, 74);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(100, 20);
            this.Nota2.TabIndex = 1;
            // 
            // Reprobo
            // 
            this.Reprobo.Location = new System.Drawing.Point(187, 44);
            this.Reprobo.Name = "Reprobo";
            this.Reprobo.Size = new System.Drawing.Size(75, 23);
            this.Reprobo.TabIndex = 2;
            this.Reprobo.Text = "Reprobo";
            this.Reprobo.UseVisualStyleBackColor = true;
            this.Reprobo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nota3
            // 
            this.Nota3.Location = new System.Drawing.Point(45, 109);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(100, 20);
            this.Nota3.TabIndex = 3;
            // 
            // NotaEvaluacion
            // 
            this.NotaEvaluacion.Location = new System.Drawing.Point(45, 145);
            this.NotaEvaluacion.Name = "NotaEvaluacion";
            this.NotaEvaluacion.Size = new System.Drawing.Size(100, 20);
            this.NotaEvaluacion.TabIndex = 4;
            this.NotaEvaluacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Evaluacion
            // 
            this.Evaluacion.Location = new System.Drawing.Point(187, 94);
            this.Evaluacion.Name = "Evaluacion";
            this.Evaluacion.Size = new System.Drawing.Size(75, 23);
            this.Evaluacion.TabIndex = 5;
            this.Evaluacion.Text = "Evaluacion";
            this.Evaluacion.UseVisualStyleBackColor = true;
            this.Evaluacion.Visible = false;
            this.Evaluacion.Click += new System.EventHandler(this.Evaluacion_Click);
            // 
            // NotaFinal
            // 
            this.NotaFinal.Location = new System.Drawing.Point(187, 142);
            this.NotaFinal.Name = "NotaFinal";
            this.NotaFinal.Size = new System.Drawing.Size(75, 23);
            this.NotaFinal.TabIndex = 6;
            this.NotaFinal.Text = "Nota Final";
            this.NotaFinal.UseVisualStyleBackColor = true;
            this.NotaFinal.Visible = false;
            this.NotaFinal.Click += new System.EventHandler(this.NotaFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 199);
            this.Controls.Add(this.NotaFinal);
            this.Controls.Add(this.Evaluacion);
            this.Controls.Add(this.NotaEvaluacion);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Reprobo);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.Nota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nota1;
        private System.Windows.Forms.TextBox Nota2;
        private System.Windows.Forms.Button Reprobo;
        private System.Windows.Forms.TextBox Nota3;
        private System.Windows.Forms.TextBox NotaEvaluacion;
        private System.Windows.Forms.Button Evaluacion;
        private System.Windows.Forms.Button NotaFinal;
    }
}

