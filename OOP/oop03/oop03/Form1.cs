using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaMannaro_Click(object sender, EventArgs e)
        {
            Mannaro m1 = new Mannaro("test");
            MessageBox.Show("Punti del mannaro: " + m1.Valore().ToString());
        }
    }
}
