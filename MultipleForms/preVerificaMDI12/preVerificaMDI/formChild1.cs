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
    public partial class formChild1 : Form
    {
        Form1 FrmParent;
        public bool pelleChild1 = true;
        public bool stoffaChild1 = true;
        public string resultChk="";
        public string resultBrand="";
        public int brandChild1 = 2;
        public formChild1()
        {
            InitializeComponent();
        }
        public formChild1(bool isPelle, bool isStoffa, int brand,Form1 frmParent)
        {
            InitializeComponent();
            brandChild1 = cmbBrands.SelectedIndex;
            this.FrmParent = frmParent;
        }

        private void chkPelle_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPelle.Checked)
                resultChk = "Interni in Pelle";
            if (resultBrand != "" && resultChk != "")
                FrmParent.frmChild2.lblResult.Text = resultBrand + " con interni in " + resultChk;
            else
                FrmParent.frmChild2.lblResult.Text = "Selezionare prima le caratteristiche";
        }

        private void chkStoffa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStoffa.Checked)
                resultChk = "Interni in Stoffa";
            //(this.Owner as Form1).fr
            
            if (resultBrand != "" && resultChk != "")
                ((Form1)this.Owner).frmChild2.lblResult.Text = resultBrand + " con interni in " + resultChk;
            else
                FrmParent.frmChild2.lblResult.Text = "Selezionare prima le caratteristiche";
        }

        private void cmbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultBrand = "Selezionato marchio " + cmbBrands.SelectedItem;
            if (resultBrand != "" && resultChk != "")
                FrmParent.frmChild2.lblResult.Text = resultBrand + " con interni in " + resultChk;
            else
                FrmParent.frmChild2.lblResult.Text = "Selezionare prima le caratteristiche";
        }
    }
}
