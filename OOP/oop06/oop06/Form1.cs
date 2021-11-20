using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop06
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneraMostro_Click(object sender, EventArgs e)
        {
            Mostro guardiano;
            if (rnd.Next(2) == 0)
                guardiano = new Mannaro();
            else
                guardiano = new Zombi();    

            MessageBox.Show("Verso come Mostro: " + guardiano.Verso());
            if (guardiano is Mannaro)
                MessageBox.Show("Verso come Mannaro: " + (guardiano as Mannaro).Verso());
            else if (guardiano is Zombi)
                MessageBox.Show("Verso come Zombi: " + (guardiano as Zombi).Verso());
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                (sender as Button).Text = "Cliccato";
            }
            if(sender is Label)
            {
                (sender as Label).BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
