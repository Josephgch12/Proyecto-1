namespace Proyecto_1.view
{
    partial class ConsultarMaquinas
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
            this.listBoxMaquinas = new System.Windows.Forms.ListBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMaquinas
            // 
            this.listBoxMaquinas.FormattingEnabled = true;
            this.listBoxMaquinas.Location = new System.Drawing.Point(131, 68);
            this.listBoxMaquinas.Name = "listBoxMaquinas";
            this.listBoxMaquinas.Size = new System.Drawing.Size(556, 225);
            this.listBoxMaquinas.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(341, 356);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // ConsultarMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1.Properties.Resources.maquina_epico;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.listBoxMaquinas);
            this.Name = "ConsultarMaquinas";
            this.Text = "ConsultarMaquinas";
            this.Load += new System.EventHandler(this.ConsultarMaquinas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMaquinas;
        private System.Windows.Forms.Button btnRefrescar;
    }
}