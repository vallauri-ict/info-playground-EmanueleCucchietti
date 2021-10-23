using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_1_Informatica_Teoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form 2 creata da designer";
            f2.Show();

        }
        private void btnApriF2b_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 creata da designer";
            f2b.Show();
        }
        private void btnF2Controlla_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtDaPassare);
            f2.Text = "Form 2 con passaggio di una TextBox";
            f2.Show();
        }

    }
}
