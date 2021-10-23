namespace preVerificaMDI
{
    partial class formChild1
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
            this.chkPelle = new System.Windows.Forms.CheckBox();
            this.chkStoffa = new System.Windows.Forms.CheckBox();
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkPelle
            // 
            this.chkPelle.AutoSize = true;
            this.chkPelle.Location = new System.Drawing.Point(12, 12);
            this.chkPelle.Name = "chkPelle";
            this.chkPelle.Size = new System.Drawing.Size(92, 17);
            this.chkPelle.TabIndex = 0;
            this.chkPelle.Text = "Interni in Pelle";
            this.chkPelle.UseVisualStyleBackColor = true;
            this.chkPelle.CheckStateChanged += new System.EventHandler(this.chkPelle_CheckStateChanged);
            // 
            // chkStoffa
            // 
            this.chkStoffa.AutoSize = true;
            this.chkStoffa.Location = new System.Drawing.Point(12, 35);
            this.chkStoffa.Name = "chkStoffa";
            this.chkStoffa.Size = new System.Drawing.Size(97, 17);
            this.chkStoffa.TabIndex = 1;
            this.chkStoffa.Text = "Interni in Stoffa";
            this.chkStoffa.UseVisualStyleBackColor = true;
            this.chkStoffa.CheckedChanged += new System.EventHandler(this.chkStoffa_CheckedChanged);
            // 
            // cmbBrands
            // 
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Items.AddRange(new object[] {
            "BMW",
            "FIAT",
            "SEAT",
            "OPEL"});
            this.cmbBrands.Location = new System.Drawing.Point(12, 58);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(121, 21);
            this.cmbBrands.TabIndex = 2;
            this.cmbBrands.SelectedIndexChanged += new System.EventHandler(this.cmbBrands_SelectedIndexChanged);
            // 
            // formChild1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 123);
            this.Controls.Add(this.cmbBrands);
            this.Controls.Add(this.chkStoffa);
            this.Controls.Add(this.chkPelle);
            this.Name = "formChild1";
            this.Text = "formChild1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPelle;
        private System.Windows.Forms.CheckBox chkStoffa;
        private System.Windows.Forms.ComboBox cmbBrands;
    }
}