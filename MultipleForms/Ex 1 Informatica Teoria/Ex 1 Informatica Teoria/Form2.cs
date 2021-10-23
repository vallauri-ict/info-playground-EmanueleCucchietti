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
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt;
        public Form2()
        {
            InitializeComponent();
            txtDaInviareF1.Text = "Aprire tramite il bottone 'passa Txt a F2' per usare questa funzionalità";
            txtDaInviareF1.Width = 500;
            txtDaInviareF1.Enabled = false;
            btnInviaF1.Enabled = false;
            btnReadF2Value.Enabled = false;

        }
        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
            MessageBox.Show(Convert.ToString(this.n));

        }
        public Form2(TextBox txt)
        {
            InitializeComponent();
            this.txt = txt;
        }

        private void btnReadF2Value_Click(object sender, EventArgs e)
        {
            if(txt == null)
                MessageBox.Show("Non è stato passato l'oggetto del textBox");
            else
                MessageBox.Show(txt.Text);
        }

        private void btnInviaF1_Click(object sender, EventArgs e)
        {
            if (txt == null)
                MessageBox.Show("Non è stato passato l'oggetto del textBox");
            else
                txt.Text = txtDaInviareF1.Text;
        }

        private void btnApriFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia fmFiglia = new FormFiglia();
            this.AddOwnedForm(fmFiglia);
            fmFiglia.Show();
        }
    }
}
