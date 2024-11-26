namespace Proyecto_1.view
{
    partial class informeContable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(216, 98);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.txtFechaInicio.TabIndex = 0;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(452, 98);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.txtFechaFin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Fin";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Location = new System.Drawing.Point(604, 156);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(123, 50);
            this.btnGenerarInforme.TabIndex = 4;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(26, 143);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultados.Size = new System.Drawing.Size(550, 281);
            this.txtResultados.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "utilizamos \"yyyy-MM-dd\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "un ejemplo es:  2023-01-01";
            // 
            // informeContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1.Properties.Resources.platilla;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Name = "informeContable";
            this.Text = "InformeContable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}