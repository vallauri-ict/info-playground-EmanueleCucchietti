using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_3
{
    public partial class Form1 : Form
    {
        public struct pazienti
        {
            public string nome;
            public int eta;
            public int temperatura;
        }
        public Form1()
        {
            InitializeComponent();
        }
        Queue<pazienti> pazientiRosso = new Queue<pazienti>();
        Queue<pazienti> pazientiGiallo = new Queue<pazienti>();
        Queue<pazienti> pazientiVerde = new Queue<pazienti>();
        Queue<pazienti> pazientiBianco = new Queue<pazienti>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
