using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preVerificaMDI
{
    public partial class formChild2 : Form
    {
        formChild1 FrmChild;
        public formChild2()
        {
            InitializeComponent();
            
        }


        private void formChild2_Load(object sender, EventArgs e)
        {
            if (((Form1)this.Owner).frmChild1 != null)
            {
                this.FrmChild = ((Form1)this.Owner).frmChild1;

                if (FrmChild.resultBrand != "" && FrmChild.resultChk != "")
                    lblResult.Text = FrmChild.resultBrand + " con interni in " + FrmChild.resultChk;
                else
                    lblResult.Text = "Selezionare prima le caratteristiche";
            }
            else
                lblResult.Text = "Selezionare prima le caratteristiche";
        }
    }
}
