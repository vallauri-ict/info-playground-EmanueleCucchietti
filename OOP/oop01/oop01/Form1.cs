using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop01
{
    public partial class Form1 : Form
    {
        Rectangle r0;
        Rectangle r1 = new Rectangle();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            r0 = new Rectangle();
            r0.side1 = Convert.ToInt32(txtBase.Text);
            r0.side2 = Convert.ToInt32(txtAltezza.Text);
            MessageBox.Show("Oggetto r -> Lati: " + r0.side1 + "-" + r0.side2);

            
            r1.side1 = Convert.ToInt32(txtBase.Text);
            r1.side2 = Convert.ToInt32(txtAltezza.Text);
            MessageBox.Show("Oggetto r -> Lati: " + r1.side1 + "-" + r1.side2);

            Rectangle t;
            t = r0;
            MessageBox.Show("Oggetto r -> Lati: " + t.side1 + "-" + t.side2);

            Rectangle f = new Rectangle();
            MessageBox.Show("Oggetto r -> Lati: " + f.side1 + "-" + f.side2);
        }
    }
}
