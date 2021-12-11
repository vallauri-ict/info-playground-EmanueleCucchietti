using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegEx02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (verifyNameRegex())
                MessageBox.Show("Name Corretto");
            else
                MessageBox.Show("Name Errato");

            if (verifyEtaRegex())
                MessageBox.Show("eta Corretto");
            else
                MessageBox.Show("eta Errato");


        }

        private bool verifyEtaRegex()
        {
            string number = " ^[0-9]$";
            Regex reg = new Regex(number);
            return (reg.IsMatch(txtNome.Text) && Convert.ToInt32(reg)>= 0 && Convert.ToInt32(reg) <= 120);
        }

        private bool verifyNameRegex()
        {
            string name = "^[a-zA-Z]{3}$";
            Regex reg = new Regex(name);
            return reg.IsMatch(txtNome.Text);
        }
        private bool verifySurnameRegex()
        {
            string name = "^[a-zA-Z]{3}$";
            Regex reg = new Regex(name);
            return reg.IsMatch(txtNome.Text);
        }
    }
}
