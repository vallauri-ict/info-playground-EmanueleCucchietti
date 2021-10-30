using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es._2_Squadra_calcio
{
    public partial class Form1 : Form
    {
        Squadre_calcio sqA;
        Squadre_calcio sqB;
        Squadre_calcio sqC;
        string[] nomiRow = { "A", "B", "C" };
        string[] nomiColumn = { "Crea", "Vince", "Pareggia" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        
        

        private void btnCreaA_Click(object sender, EventArgs e)
        {
            sqA = new Squadre_calcio("Atlante", "Montecauto", 0, 0, 0);
            txtCittaA.Text = sqA.citta.ToString();
            txtValoreA.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();


        }

        private void btnCreaB_Click(object sender, EventArgs e)
        {
            sqB = new Squadre_calcio("Macedonia", "Golfo Aranci", 0, 0, 0);
            txtCittaB.Text = sqB.citta.ToString();
            txtValoreB.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();

        }

        private void btnCreaC_Click(object sender, EventArgs e)
        {
            sqC = new Squadre_calcio("Virtus", "Città Vecchia", 0, 0, 0);
            txtCittaC.Text = sqC.citta.ToString();
            txtValoreC.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();


        }

        private void btnAVince_Click(object sender, EventArgs e)
        {
            sqA.vinte++;
            txtValoreA.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();

        }

        private void btnBVince_Click(object sender, EventArgs e)
        {
            sqB.vinte++;
            txtValoreB.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();

        }

        private void btnCVince_Click(object sender, EventArgs e)
        {
            sqC.vinte++;
            txtValoreC.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();

        }

        private void btnPareggiaA_Click(object sender, EventArgs e)
        {
            sqA.pareggiate++;
            txtValoreA.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();

        }

        private void btnPareggiaB_Click(object sender, EventArgs e)
        {
            sqB.pareggiate++;
            txtValoreB.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();

        }

        private void btnPareggiaC_Click(object sender, EventArgs e)
        {
            sqC.pareggiate++;
            txtValoreC.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();

        }
    }
}
