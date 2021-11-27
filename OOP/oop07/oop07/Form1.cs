using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Prova con lato = 5");
                FactoryQuadrato quadrato = FactoryQuadrato.creaQuadrato(5);
                MessageBox.Show("Prova con lato = 0");
                FactoryQuadrato quadrato2 = FactoryQuadrato.creaQuadrato(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creazione primo oggetto singleton");
            Singleton s1 = Singleton.GetIstance();
            MessageBox.Show("Progressivo: " + s1.n);

            MessageBox.Show("Prova creazione secondo oggetto singleton");
            Singleton s2 = Singleton.GetIstance();
            MessageBox.Show("Progressivo: " + s2.n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringheIndexate s = new StringheIndexate(10);

            for (int i = 0; i < 10; i++)
            {
                s[i] = i.ToString();
            }

            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("Stringa " + i + ": " + s[i]);
            }
        }
    }
}
