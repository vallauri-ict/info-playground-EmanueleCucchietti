namespace Code_3
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmUDtemp = new System.Windows.Forms.NumericUpDown();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnPreleva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDtemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(90, 42);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 3;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(12, 45);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(26, 13);
            this.lblEta.TabIndex = 2;
            this.lblEta.Text = "Età:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colore: ";
            // 
            // cmbColore
            // 
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Items.AddRange(new object[] {
            "Rosso",
            "Giallo",
            "Verde",
            "Bianco"});
            this.cmbColore.Location = new System.Drawing.Point(90, 94);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(100, 21);
            this.cmbColore.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperatura:";
            // 
            // nmUDtemp
            // 
            this.nmUDtemp.Location = new System.Drawing.Point(90, 68);
            this.nmUDtemp.Name = "nmUDtemp";
            this.nmUDtemp.Size = new System.Drawing.Size(100, 20);
            this.nmUDtemp.TabIndex = 8;
            this.nmUDtemp.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(227, 16);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(103, 23);
            this.btnAddPatient.TabIndex = 9;
            this.btnAddPatient.Text = "Aggiungi Paziente";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnPreleva
            // 
            this.btnPreleva.Location = new System.Drawing.Point(227, 97);
            this.btnPreleva.Name = "btnPreleva";
            this.btnPreleva.Size = new System.Drawing.Size(103, 23);
            this.btnPreleva.TabIndex = 10;
            this.btnPreleva.Text = "Preleva Paziente";
            this.btnPreleva.UseVisualStyleBackColor = true;
            this.btnPreleva.Click += new System.EventHandler(this.btnPreleva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPreleva);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.nmUDtemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbColore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmUDtemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmUDtemp;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnPreleva;
    }
}

