namespace Ex_2_Informatica_Teoria
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
            this.btnApriF1 = new System.Windows.Forms.Button();
            this.btnApriF2 = new System.Windows.Forms.Button();
            this.btnShowOpenChildren = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApriF1
            // 
            this.btnApriF1.Location = new System.Drawing.Point(12, 27);
            this.btnApriF1.Name = "btnApriF1";
            this.btnApriF1.Size = new System.Drawing.Size(75, 23);
            this.btnApriF1.TabIndex = 1;
            this.btnApriF1.Text = "Apri f1";
            this.btnApriF1.UseVisualStyleBackColor = true;
            this.btnApriF1.Click += new System.EventHandler(this.btnApriF1_Click);
            // 
            // btnApriF2
            // 
            this.btnApriF2.Location = new System.Drawing.Point(93, 27);
            this.btnApriF2.Name = "btnApriF2";
            this.btnApriF2.Size = new System.Drawing.Size(75, 23);
            this.btnApriF2.TabIndex = 2;
            this.btnApriF2.Text = "Apri F2";
            this.btnApriF2.UseVisualStyleBackColor = true;
            this.btnApriF2.Click += new System.EventHandler(this.btnApriF2_Click);
            // 
            // btnShowOpenChildren
            // 
            this.btnShowOpenChildren.Location = new System.Drawing.Point(174, 27);
            this.btnShowOpenChildren.Name = "btnShowOpenChildren";
            this.btnShowOpenChildren.Size = new System.Drawing.Size(123, 23);
            this.btnShowOpenChildren.TabIndex = 3;
            this.btnShowOpenChildren.Text = "Mostra Figlie Aperte";
            this.btnShowOpenChildren.UseVisualStyleBackColor = true;
            this.btnShowOpenChildren.Click += new System.EventHandler(this.btnShowOpenChildren_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apri1ToolStripMenuItem,
            this.apri2ToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // apri1ToolStripMenuItem
            // 
            this.apri1ToolStripMenuItem.Name = "apri1ToolStripMenuItem";
            this.apri1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apri1ToolStripMenuItem.Text = "Apri&1";
            this.apri1ToolStripMenuItem.Click += new System.EventHandler(this.apri1ToolStripMenuItem_Click);
            // 
            // apri2ToolStripMenuItem
            // 
            this.apri2ToolStripMenuItem.Name = "apri2ToolStripMenuItem";
            this.apri2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apri2ToolStripMenuItem.Text = "Apri2&";
            this.apri2ToolStripMenuItem.Click += new System.EventHandler(this.apri2ToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "In&fo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 22);
            this.toolStripMenuItem2.Text = "&?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 17);
            this.lblStatus.Text = "Benvenuto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnShowOpenChildren);
            this.Controls.Add(this.btnApriF2);
            this.Controls.Add(this.btnApriF1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApriF1;
        private System.Windows.Forms.Button btnApriF2;
        private System.Windows.Forms.Button btnShowOpenChildren;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

