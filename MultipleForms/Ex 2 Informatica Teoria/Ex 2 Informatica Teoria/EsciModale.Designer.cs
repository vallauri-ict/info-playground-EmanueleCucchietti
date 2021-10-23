namespace Ex_2_Informatica_Teoria
{
    partial class EsciModale
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
            this.btnOkEsci = new System.Windows.Forms.Button();
            this.btnAnnullaEsci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuoi davvero Uscire?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "I dati non salvati andranno perduti";
            // 
            // btnOkEsci
            // 
            this.btnOkEsci.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkEsci.Location = new System.Drawing.Point(144, 75);
            this.btnOkEsci.Name = "btnOkEsci";
            this.btnOkEsci.Size = new System.Drawing.Size(75, 23);
            this.btnOkEsci.TabIndex = 2;
            this.btnOkEsci.Text = "Ok";
            this.btnOkEsci.UseVisualStyleBackColor = true;
            this.btnOkEsci.Click += new System.EventHandler(this.btnOkEsci_Click);
            // 
            // btnAnnullaEsci
            // 
            this.btnAnnullaEsci.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnullaEsci.Location = new System.Drawing.Point(225, 75);
            this.btnAnnullaEsci.Name = "btnAnnullaEsci";
            this.btnAnnullaEsci.Size = new System.Drawing.Size(75, 23);
            this.btnAnnullaEsci.TabIndex = 3;
            this.btnAnnullaEsci.Text = "Annulla";
            this.btnAnnullaEsci.UseVisualStyleBackColor = true;
            this.btnAnnullaEsci.Click += new System.EventHandler(this.btnAnnullaEsci_Click);
            // 
            // EsciModale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 112);
            this.Controls.Add(this.btnAnnullaEsci);
            this.Controls.Add(this.btnOkEsci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EsciModale";
            this.Text = "EsciModale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOkEsci;
        private System.Windows.Forms.Button btnAnnullaEsci;
    }
}