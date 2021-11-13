using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_2
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> articoli = new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
        }   
        int pos;

        private void Form1_Load(object sender, EventArgs e)
        {
            pos = 0;
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            articoli.Add(pos++, txtNomeArticolo.Text);
            stampaNumeroArticoli();
        }
        private void btnFindKey_Click(object sender, EventArgs e)
        {
            string str = articoli[Convert.ToInt32(numericUpDown1.Value)];
            MessageBox.Show("Articolo in posizione " + numericUpDown1.Value + ": " + str);
        }
        private void stampaNumeroArticoli()
        {
            lblArticoli.Text = "Numero Articoli: " + pos;
        }
    }
}
