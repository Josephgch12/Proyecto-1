namespace Proyecto_1.view
{
    partial class NotificacionesMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificacionesMantenimiento));
            this.comboBoxMaquinas = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMaquinas
            // 
            this.comboBoxMaquinas.FormattingEnabled = true;
            this.comboBoxMaquinas.Location = new System.Drawing.Point(282, 153);
            this.comboBoxMaquinas.Name = "comboBoxMaquinas";
            this.comboBoxMaquinas.Size = new System.Drawing.Size(169, 21);
            this.comboBoxMaquinas.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(282, 124);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Máquinas a 3 meses o menos de vida útil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // NotificacionesMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1.Properties.Resources.maquina_epico;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.comboBoxMaquinas);
            this.Name = "NotificacionesMantenimiento";
            this.Text = "NotificacionesMantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMaquinas;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}