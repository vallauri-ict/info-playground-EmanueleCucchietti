namespace Dictionary_2
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
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.txtNomeArticolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindKey = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblArticoli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(61, 36);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(101, 23);
            this.btnAddArticle.TabIndex = 0;
            this.btnAddArticle.Text = "Aggiungi Articolo";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // txtNomeArticolo
            // 
            this.txtNomeArticolo.Location = new System.Drawing.Point(61, 10);
            this.txtNomeArticolo.Name = "txtNomeArticolo";
            this.txtNomeArticolo.Size = new System.Drawing.Size(100, 20);
            this.txtNomeArticolo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // btnFindKey
            // 
            this.btnFindKey.Location = new System.Drawing.Point(195, 8);
            this.btnFindKey.Name = "btnFindKey";
            this.btnFindKey.Size = new System.Drawing.Size(102, 23);
            this.btnFindKey.TabIndex = 5;
            this.btnFindKey.Text = "Trova Chiave";
            this.btnFindKey.UseVisualStyleBackColor = true;
            this.btnFindKey.Click += new System.EventHandler(this.btnFindKey_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 10);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(199, 41);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(93, 13);
            this.lblArticoli.TabIndex = 7;
            this.lblArticoli.Text = "Numero Articoli : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnFindKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeArticolo);
            this.Controls.Add(this.btnAddArticle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.TextBox txtNomeArticolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindKey;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblArticoli;
    }
}

