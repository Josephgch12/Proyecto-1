namespace Proyecto_1.view
{
    partial class AgregarEntrenador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEntrenador = new System.Windows.Forms.TextBox();
            this.txtPuntosFuertes = new System.Windows.Forms.TextBox();
            this.txtHorarios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrenador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punto Fuerte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horarios:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(348, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEntrenador
            // 
            this.txtEntrenador.Location = new System.Drawing.Point(323, 96);
            this.txtEntrenador.Name = "txtEntrenador";
            this.txtEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtEntrenador.TabIndex = 4;
            // 
            // txtPuntosFuertes
            // 
            this.txtPuntosFuertes.Location = new System.Drawing.Point(323, 129);
            this.txtPuntosFuertes.Name = "txtPuntosFuertes";
            this.txtPuntosFuertes.Size = new System.Drawing.Size(100, 20);
            this.txtPuntosFuertes.TabIndex = 5;
            // 
            // txtHorarios
            // 
            this.txtHorarios.Location = new System.Drawing.Point(323, 167);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(100, 20);
            this.txtHorarios.TabIndex = 6;
            // 
            // AgregarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1.Properties.Resources._321;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHorarios);
            this.Controls.Add(this.txtPuntosFuertes);
            this.Controls.Add(this.txtEntrenador);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarEntrenador";
            this.Text = "AgregarEntrenador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEntrenador;
        private System.Windows.Forms.TextBox txtPuntosFuertes;
        private System.Windows.Forms.TextBox txtHorarios;
    }
}