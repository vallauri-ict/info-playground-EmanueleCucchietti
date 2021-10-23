using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using preVerificaMDI;

namespace preVerificaMDI
{
    public partial class Form1 : Form
    {
        public formChild1 frmChild1;
        public formChild2 frmChild2;
        public bool IsPelle= true;
        public bool IsStoffa = true;
        public int Brand = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            modaleChiudi modaleChiusura = new modaleChiudi();
            if(modaleChiusura.ShowDialog() != DialogResult.OK)
                e.Cancel = true;
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild1 = new formChild1(IsPelle,IsStoffa,Brand,this);
            this.AddOwnedForm(frmChild1);
            frmChild1.MdiParent = this;
            frmChild1.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild2 = new formChild2();
            this.AddOwnedForm(frmChild2);
            frmChild2.MdiParent = this;
            frmChild2.Show();
        }
    }
}
