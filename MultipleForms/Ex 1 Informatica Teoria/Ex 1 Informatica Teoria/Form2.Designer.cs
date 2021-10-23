namespace Ex_1_Informatica_Teoria
{
    partial class Form2
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
            this.btnReadF2Value = new System.Windows.Forms.Button();
            this.btnInviaF1 = new System.Windows.Forms.Button();
            this.txtDaInviareF1 = new System.Windows.Forms.TextBox();
            this.btnApriFormFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sono la Form 2";
            // 
            // btnReadF2Value
            // 
            this.btnReadF2Value.Location = new System.Drawing.Point(12, 34);
            this.btnReadF2Value.Name = "btnReadF2Value";
            this.btnReadF2Value.Size = new System.Drawing.Size(75, 23);
            this.btnReadF2Value.TabIndex = 1;
            this.btnReadF2Value.Text = "Leggi Valore";
            this.btnReadF2Value.UseVisualStyleBackColor = true;
            this.btnReadF2Value.Click += new System.EventHandler(this.btnReadF2Value_Click);
            // 
            // btnInviaF1
            // 
            this.btnInviaF1.Location = new System.Drawing.Point(118, 107);
            this.btnInviaF1.Name = "btnInviaF1";
            this.btnInviaF1.Size = new System.Drawing.Size(99, 23);
            this.btnInviaF1.TabIndex = 2;
            this.btnInviaF1.Text = "Invia a form 1";
            this.btnInviaF1.UseVisualStyleBackColor = true;
            this.btnInviaF1.Click += new System.EventHandler(this.btnInviaF1_Click);
            // 
            // txtDaInviareF1
            // 
            this.txtDaInviareF1.Location = new System.Drawing.Point(12, 107);
            this.txtDaInviareF1.Name = "txtDaInviareF1";
            this.txtDaInviareF1.Size = new System.Drawing.Size(100, 20);
            this.txtDaInviareF1.TabIndex = 3;
            // 
            // btnApriFormFiglia
            // 
            this.btnApriFormFiglia.Location = new System.Drawing.Point(15, 181);
            this.btnApriFormFiglia.Name = "btnApriFormFiglia";
            this.btnApriFormFiglia.Size = new System.Drawing.Size(116, 23);
            this.btnApriFormFiglia.TabIndex = 4;
            this.btnApriFormFiglia.Text = "Apri form Figlia";
            this.btnApriFormFiglia.UseVisualStyleBackColor = true;
            this.btnApriFormFiglia.Click += new System.EventHandler(this.btnApriFormFiglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApriFormFiglia);
            this.Controls.Add(this.txtDaInviareF1);
            this.Controls.Add(this.btnInviaF1);
            this.Controls.Add(this.btnReadF2Value);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadF2Value;
        private System.Windows.Forms.Button btnInviaF1;
        private System.Windows.Forms.TextBox txtDaInviareF1;
        private System.Windows.Forms.Button btnApriFormFiglia;
    }
}