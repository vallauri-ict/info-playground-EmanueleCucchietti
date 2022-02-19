namespace interfacciaStrumenti
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
            this.btnRumorista = new System.Windows.Forms.Button();
            this.btnChitarra = new System.Windows.Forms.Button();
            this.btnTromba = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRumorista
            // 
            this.btnRumorista.Location = new System.Drawing.Point(12, 12);
            this.btnRumorista.Name = "btnRumorista";
            this.btnRumorista.Size = new System.Drawing.Size(94, 29);
            this.btnRumorista.TabIndex = 0;
            this.btnRumorista.Text = "Rumorista";
            this.btnRumorista.UseVisualStyleBackColor = true;
            this.btnRumorista.Click += new System.EventHandler(this.btnRumorista_Click);
            // 
            // btnChitarra
            // 
            this.btnChitarra.Location = new System.Drawing.Point(112, 12);
            this.btnChitarra.Name = "btnChitarra";
            this.btnChitarra.Size = new System.Drawing.Size(94, 29);
            this.btnChitarra.TabIndex = 1;
            this.btnChitarra.Text = "Chitarra";
            this.btnChitarra.UseVisualStyleBackColor = true;
            this.btnChitarra.Click += new System.EventHandler(this.btnChitarra_Click);
            // 
            // btnTromba
            // 
            this.btnTromba.Location = new System.Drawing.Point(212, 12);
            this.btnTromba.Name = "btnTromba";
            this.btnTromba.Size = new System.Drawing.Size(94, 29);
            this.btnTromba.TabIndex = 2;
            this.btnTromba.Text = "Tromba";
            this.btnTromba.UseVisualStyleBackColor = true;
            this.btnTromba.Click += new System.EventHandler(this.btnTromba_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(112, 106);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(94, 29);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnTromba);
            this.Controls.Add(this.btnChitarra);
            this.Controls.Add(this.btnRumorista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRumorista;
        private Button btnChitarra;
        private Button btnTromba;
        private Button btnPlay;
    }
}