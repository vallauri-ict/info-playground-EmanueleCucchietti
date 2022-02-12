namespace Abstr2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLanciaDado = new System.Windows.Forms.Button();
            this.btnLanciaMoneta = new System.Windows.Forms.Button();
            this.btnLanciaMonetaAbstr = new System.Windows.Forms.Button();
            this.btnLanciaDadoAbstr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLanciaDado
            // 
            this.btnLanciaDado.Location = new System.Drawing.Point(12, 12);
            this.btnLanciaDado.Name = "btnLanciaDado";
            this.btnLanciaDado.Size = new System.Drawing.Size(158, 29);
            this.btnLanciaDado.TabIndex = 0;
            this.btnLanciaDado.Text = "Lancia Dado";
            this.btnLanciaDado.UseVisualStyleBackColor = true;
            this.btnLanciaDado.Click += new System.EventHandler(this.btnLanciaDado_Click);
            // 
            // btnLanciaMoneta
            // 
            this.btnLanciaMoneta.Location = new System.Drawing.Point(630, 12);
            this.btnLanciaMoneta.Name = "btnLanciaMoneta";
            this.btnLanciaMoneta.Size = new System.Drawing.Size(158, 29);
            this.btnLanciaMoneta.TabIndex = 1;
            this.btnLanciaMoneta.Text = "Lancia Moneta";
            this.btnLanciaMoneta.UseVisualStyleBackColor = true;
            this.btnLanciaMoneta.Click += new System.EventHandler(this.btnLanciaMoneta_Click);
            // 
            // btnLanciaMonetaAbstr
            // 
            this.btnLanciaMonetaAbstr.Location = new System.Drawing.Point(630, 211);
            this.btnLanciaMonetaAbstr.Name = "btnLanciaMonetaAbstr";
            this.btnLanciaMonetaAbstr.Size = new System.Drawing.Size(158, 29);
            this.btnLanciaMonetaAbstr.TabIndex = 3;
            this.btnLanciaMonetaAbstr.Text = "Lancia Moneta";
            this.btnLanciaMonetaAbstr.UseVisualStyleBackColor = true;
            this.btnLanciaMonetaAbstr.Click += new System.EventHandler(this.btnLanciaMonetaAbstr_Click);
            // 
            // btnLanciaDadoAbstr
            // 
            this.btnLanciaDadoAbstr.Location = new System.Drawing.Point(12, 211);
            this.btnLanciaDadoAbstr.Name = "btnLanciaDadoAbstr";
            this.btnLanciaDadoAbstr.Size = new System.Drawing.Size(158, 29);
            this.btnLanciaDadoAbstr.TabIndex = 2;
            this.btnLanciaDadoAbstr.Text = "Lancia Dado";
            this.btnLanciaDadoAbstr.UseVisualStyleBackColor = true;
            this.btnLanciaDadoAbstr.Click += new System.EventHandler(this.btnLanciaDadoAbstr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Astratta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLanciaMonetaAbstr);
            this.Controls.Add(this.btnLanciaDadoAbstr);
            this.Controls.Add(this.btnLanciaMoneta);
            this.Controls.Add(this.btnLanciaDado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLanciaDado;
        private Button btnLanciaMoneta;
        private Button btnLanciaMonetaAbstr;
        private Button btnLanciaDadoAbstr;
        private Label label1;
    }
}