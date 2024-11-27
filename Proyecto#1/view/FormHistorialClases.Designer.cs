namespace Proyecto_1.view
{
    partial class FormHistorialClases
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
            this.txtCantidadClases = new System.Windows.Forms.TextBox();
            this.txtEntrenadorFavorito = new System.Windows.Forms.TextBox();
            this.listBoxHistorial = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clases Favorita Matriculadas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Historial Clases";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Clases";
            // 
            // txtCantidadClases
            // 
            this.txtCantidadClases.Location = new System.Drawing.Point(419, 108);
            this.txtCantidadClases.Name = "txtCantidadClases";
            this.txtCantidadClases.ReadOnly = true;
            this.txtCantidadClases.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadClases.TabIndex = 3;
            // 
            // txtEntrenadorFavorito
            // 
            this.txtEntrenadorFavorito.Location = new System.Drawing.Point(187, 105);
            this.txtEntrenadorFavorito.Name = "txtEntrenadorFavorito";
            this.txtEntrenadorFavorito.ReadOnly = true;
            this.txtEntrenadorFavorito.Size = new System.Drawing.Size(100, 20);
            this.txtEntrenadorFavorito.TabIndex = 4;
            // 
            // listBoxHistorial
            // 
            this.listBoxHistorial.FormattingEnabled = true;
            this.listBoxHistorial.Location = new System.Drawing.Point(178, 172);
            this.listBoxHistorial.Name = "listBoxHistorial";
            this.listBoxHistorial.Size = new System.Drawing.Size(587, 225);
            this.listBoxHistorial.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "matriculadas";
            // 
            // FormHistorialClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1.Properties.Resources.membresias_foto;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxHistorial);
            this.Controls.Add(this.txtEntrenadorFavorito);
            this.Controls.Add(this.txtCantidadClases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormHistorialClases";
            this.Text = "FormHistorialClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadClases;
        private System.Windows.Forms.TextBox txtEntrenadorFavorito;
        private System.Windows.Forms.ListBox listBoxHistorial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}