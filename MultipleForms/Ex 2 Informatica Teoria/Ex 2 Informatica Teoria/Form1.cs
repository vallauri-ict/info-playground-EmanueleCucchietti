using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_2_Informatica_Teoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnApriF1_Click(object sender, EventArgs e)
        {
            Figlia1 f1 = new Figlia1();
            f1.MdiParent = this;
            f1.Text = "Figlia 1";
            f1.Size = new Size(200, 150);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(0, 40);
            //f1.Location = this.Location;
            f1.Show();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Figlia2 f2 = new Figlia2();
            f2.MdiParent = this;
            f2.Text = "Figlia 2";
            f2.Size = new Size(200, 150);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(200, 40);
            //f2.Location = this.Location;
            f2.Show();
        }

        private void btnShowOpenChildren_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte: "+this.MdiChildren.Length+" Finestre figlie");
            string output="";
            foreach (Form f in this.MdiChildren)
                output += "Finestra: " + f.Text+"\n";
            if (output != "")
                MessageBox.Show(output);
        }

        private void apriF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "Premuto Apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Premuto Apri 2";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EsciModale modaleEsci = new EsciModale();
            modaleEsci.Text = "Uscire?";
            if (modaleEsci.ShowDialog() != DialogResult.OK)
                e.Cancel = true;
        }
    }
}
