using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop02
{
    public partial class Form1 : Form
    {
        Persona abele = new Persona();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            abele.età = 17;
            MessageBox.Show("Età prima del richiamo a Compleanno: \n" + abele.età);
            abele.Compleanno(abele);
            MessageBox.Show("Età dopo del richiamo a Compleanno: \n" + abele.età);
        }
        
        private void Supplenza(ref Persona p)
        {
            p = new Persona();
            p.età = 27;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            abele.età = 54;
            MessageBox.Show("Età prima del richiamo a Compleanno: \n" + abele.età);
            Supplenza(ref abele);
            MessageBox.Show("Età dopo del richiamo a Compleanno: \n" + abele.età);;
        }
    }
}
