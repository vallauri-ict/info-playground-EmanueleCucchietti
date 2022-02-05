namespace Abstr1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaggio = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLato2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLato1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAreaCilindro = new System.Windows.Forms.Button();
            this.btnAreaParallelepipedo = new System.Windows.Forms.Button();
            this.btnVolumeCilindro = new System.Windows.Forms.Button();
            this.btnVolumeParallelepipedo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raggio:";
            // 
            // txtRaggio
            // 
            this.txtRaggio.Location = new System.Drawing.Point(78, 15);
            this.txtRaggio.Name = "txtRaggio";
            this.txtRaggio.Size = new System.Drawing.Size(125, 27);
            this.txtRaggio.TabIndex = 1;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(78, 176);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(125, 27);
            this.txtAltezza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altezza:";
            // 
            // txtLato2
            // 
            this.txtLato2.Location = new System.Drawing.Point(451, 51);
            this.txtLato2.Name = "txtLato2";
            this.txtLato2.Size = new System.Drawing.Size(125, 27);
            this.txtLato2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lato2:";
            // 
            // txtLato1
            // 
            this.txtLato1.Location = new System.Drawing.Point(451, 18);
            this.txtLato1.Name = "txtLato1";
            this.txtLato1.Size = new System.Drawing.Size(125, 27);
            this.txtLato1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lato1:";
            // 
            // btnAreaCilindro
            // 
            this.btnAreaCilindro.Location = new System.Drawing.Point(12, 209);
            this.btnAreaCilindro.Name = "btnAreaCilindro";
            this.btnAreaCilindro.Size = new System.Drawing.Size(198, 29);
            this.btnAreaCilindro.TabIndex = 8;
            this.btnAreaCilindro.Text = "Area Cilindro";
            this.btnAreaCilindro.UseVisualStyleBackColor = true;
            this.btnAreaCilindro.Click += new System.EventHandler(this.btnAreaCilindro_Click);
            // 
            // btnAreaParallelepipedo
            // 
            this.btnAreaParallelepipedo.Location = new System.Drawing.Point(385, 209);
            this.btnAreaParallelepipedo.Name = "btnAreaParallelepipedo";
            this.btnAreaParallelepipedo.Size = new System.Drawing.Size(198, 29);
            this.btnAreaParallelepipedo.TabIndex = 9;
            this.btnAreaParallelepipedo.Text = "Area Parallelepipedo";
            this.btnAreaParallelepipedo.UseVisualStyleBackColor = true;
            // 
            // btnVolumeCilindro
            // 
            this.btnVolumeCilindro.Location = new System.Drawing.Point(12, 244);
            this.btnVolumeCilindro.Name = "btnVolumeCilindro";
            this.btnVolumeCilindro.Size = new System.Drawing.Size(198, 29);
            this.btnVolumeCilindro.TabIndex = 10;
            this.btnVolumeCilindro.Text = "Volume Cilindro";
            this.btnVolumeCilindro.UseVisualStyleBackColor = true;
            this.btnVolumeCilindro.Click += new System.EventHandler(this.btnVolumeCilindro_Click);
            // 
            // btnVolumeParallelepipedo
            // 
            this.btnVolumeParallelepipedo.Location = new System.Drawing.Point(385, 244);
            this.btnVolumeParallelepipedo.Name = "btnVolumeParallelepipedo";
            this.btnVolumeParallelepipedo.Size = new System.Drawing.Size(198, 29);
            this.btnVolumeParallelepipedo.TabIndex = 11;
            this.btnVolumeParallelepipedo.Text = "Volume Parallelepipedo";
            this.btnVolumeParallelepipedo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolumeParallelepipedo);
            this.Controls.Add(this.btnVolumeCilindro);
            this.Controls.Add(this.btnAreaParallelepipedo);
            this.Controls.Add(this.btnAreaCilindro);
            this.Controls.Add(this.txtLato2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLato1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRaggio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtRaggio;
        private TextBox txtAltezza;
        private Label label2;
        private TextBox txtLato2;
        private Label label3;
        private TextBox txtLato1;
        private Label label4;
        private Button btnAreaCilindro;
        private Button btnAreaParallelepipedo;
        private Button btnVolumeCilindro;
        private Button btnVolumeParallelepipedo;
    }
}