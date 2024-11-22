namespace Proyecto_1.view
{
    partial class MatricularClase
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
            this.comboBoxEntrenadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEntrenadores
            // 
            this.comboBoxEntrenadores.FormattingEnabled = true;
            this.comboBoxEntrenadores.Location = new System.Drawing.Point(253, 144);
            this.comboBoxEntrenadores.Name = "comboBoxEntrenadores";
            this.comboBoxEntrenadores.Size = new System.Drawing.Size(359, 21);
            this.comboBoxEntrenadores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "eliga la clase que desee :)";
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(380, 171);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(75, 23);
            this.btnMatricular.TabIndex = 2;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // MatricularClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1.Properties.Resources._321;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEntrenadores);
            this.Name = "MatricularClase";
            this.Text = "MatricularClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEntrenadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatricular;
    }
}