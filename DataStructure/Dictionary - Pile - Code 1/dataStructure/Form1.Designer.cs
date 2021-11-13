namespace dataStructure
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAggiungiLibro = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVisLibri = new System.Windows.Forms.Button();
            this.posNupdown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCoda = new System.Windows.Forms.Button();
            this.btnEstraiCoda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddLibroPila = new System.Windows.Forms.Button();
            this.btnEstraiLibroPila = new System.Windows.Forms.Button();
            this.btnVisPos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.posNupdown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo:";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(85, 10);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(85, 36);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore:";
            // 
            // btnAggiungiLibro
            // 
            this.btnAggiungiLibro.Location = new System.Drawing.Point(6, 19);
            this.btnAggiungiLibro.Name = "btnAggiungiLibro";
            this.btnAggiungiLibro.Size = new System.Drawing.Size(125, 23);
            this.btnAggiungiLibro.TabIndex = 4;
            this.btnAggiungiLibro.Text = "AggiungiLibro";
            this.btnAggiungiLibro.UseVisualStyleBackColor = true;
            this.btnAggiungiLibro.Click += new System.EventHandler(this.btnAggiungiLibro_Click);
            // 
            // btnVisLibri
            // 
            this.btnVisLibri.Location = new System.Drawing.Point(6, 48);
            this.btnVisLibri.Name = "btnVisLibri";
            this.btnVisLibri.Size = new System.Drawing.Size(125, 23);
            this.btnVisLibri.TabIndex = 5;
            this.btnVisLibri.Text = "VisualizzaLIbri";
            this.btnVisLibri.UseVisualStyleBackColor = true;
            this.btnVisLibri.Click += new System.EventHandler(this.btnVisLibri_Click);
            // 
            // posNupdown
            // 
            this.posNupdown.Location = new System.Drawing.Point(137, 80);
            this.posNupdown.Name = "posNupdown";
            this.posNupdown.Size = new System.Drawing.Size(52, 20);
            this.posNupdown.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAggiungiLibro);
            this.groupBox1.Controls.Add(this.posNupdown);
            this.groupBox1.Controls.Add(this.btnVisLibri);
            this.groupBox1.Controls.Add(this.btnVisPos);
            this.groupBox1.Location = new System.Drawing.Point(204, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dictionary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddCoda);
            this.groupBox2.Controls.Add(this.btnEstraiCoda);
            this.groupBox2.Location = new System.Drawing.Point(204, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 84);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coda";
            // 
            // btnAddCoda
            // 
            this.btnAddCoda.Location = new System.Drawing.Point(6, 19);
            this.btnAddCoda.Name = "btnAddCoda";
            this.btnAddCoda.Size = new System.Drawing.Size(125, 23);
            this.btnAddCoda.TabIndex = 4;
            this.btnAddCoda.Text = "AggiungiLibro";
            this.btnAddCoda.UseVisualStyleBackColor = true;
            this.btnAddCoda.Click += new System.EventHandler(this.btnAddCoda_Click);
            // 
            // btnEstraiCoda
            // 
            this.btnEstraiCoda.Location = new System.Drawing.Point(6, 48);
            this.btnEstraiCoda.Name = "btnEstraiCoda";
            this.btnEstraiCoda.Size = new System.Drawing.Size(125, 23);
            this.btnEstraiCoda.TabIndex = 5;
            this.btnEstraiCoda.Text = "EstraiLibro";
            this.btnEstraiCoda.UseVisualStyleBackColor = true;
            this.btnEstraiCoda.Click += new System.EventHandler(this.btnEstraiCoda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddLibroPila);
            this.groupBox3.Controls.Add(this.btnEstraiLibroPila);
            this.groupBox3.Location = new System.Drawing.Point(204, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 79);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coda";
            // 
            // btnAddLibroPila
            // 
            this.btnAddLibroPila.Location = new System.Drawing.Point(6, 19);
            this.btnAddLibroPila.Name = "btnAddLibroPila";
            this.btnAddLibroPila.Size = new System.Drawing.Size(125, 23);
            this.btnAddLibroPila.TabIndex = 4;
            this.btnAddLibroPila.Text = "AggiungiLibro";
            this.btnAddLibroPila.UseVisualStyleBackColor = true;
            this.btnAddLibroPila.Click += new System.EventHandler(this.btnAddLibroPila_Click);
            // 
            // btnEstraiLibroPila
            // 
            this.btnEstraiLibroPila.Location = new System.Drawing.Point(6, 48);
            this.btnEstraiLibroPila.Name = "btnEstraiLibroPila";
            this.btnEstraiLibroPila.Size = new System.Drawing.Size(125, 23);
            this.btnEstraiLibroPila.TabIndex = 5;
            this.btnEstraiLibroPila.Text = "EstraiLibro";
            this.btnEstraiLibroPila.UseVisualStyleBackColor = true;
            this.btnEstraiLibroPila.Click += new System.EventHandler(this.btnEstraiLibroPila_Click);
            // 
            // btnVisPos
            // 
            this.btnVisPos.Location = new System.Drawing.Point(6, 77);
            this.btnVisPos.Name = "btnVisPos";
            this.btnVisPos.Size = new System.Drawing.Size(125, 23);
            this.btnVisPos.TabIndex = 6;
            this.btnVisPos.Text = "Visualizza Libro in pos: ";
            this.btnVisPos.UseVisualStyleBackColor = true;
            this.btnVisPos.Click += new System.EventHandler(this.btnVisPos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posNupdown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAggiungiLibro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVisLibri;
        private System.Windows.Forms.NumericUpDown posNupdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCoda;
        private System.Windows.Forms.Button btnEstraiCoda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddLibroPila;
        private System.Windows.Forms.Button btnEstraiLibroPila;
        private System.Windows.Forms.Button btnVisPos;
    }
}

