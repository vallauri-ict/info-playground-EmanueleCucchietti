using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila4
{
    public partial class Form1 : Form
    {
        public struct container
        {
            public string codice;
            public int peso;
            public int tara;
        }
        Stack<container> containers = new Stack<container>();
        public Form1()
        {
            InitializeComponent();
        }
        private void loadContainer_Click(object sender, EventArgs e)
        {
            inserisciContainer();
            clearFields();
        }
        private void clearFields()
        {
            txtCodice.Text = "";
            txtPeso.Text = "";
            txtTara.Text = "";
        }
        private void inserisciContainer()
        {
            container cnt = new container();
            cnt.codice = txtCodice.Text;
            cnt.peso = Convert.ToInt32(txtPeso.Text);
            cnt.tara = Convert.ToInt32(txtTara.Text);
            containers.Push(cnt);
        }
        private void removeContainer_Click(object sender, EventArgs e)
        {
            if (containers.Count != 0)
            {
                container cnt;
                cnt = containers.Pop();
                MessageBox.Show(
                    "Il container prelevato è: \n"
                    +
                    "Codice: " + cnt.codice + "\n"
                    +
                    "Peso: " + cnt.peso + "\n"
                    +
                    "Tara: " + cnt.tara + "\n"
                    );
            }
            else
                MessageBox.Show("Stack vuoto");
        }
    }
}
