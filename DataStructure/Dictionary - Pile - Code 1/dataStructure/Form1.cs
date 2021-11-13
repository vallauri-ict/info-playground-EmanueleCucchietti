using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataStructure
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public string titolo;
            public string autore;
        }
        int pos;

        Dictionary<int, Libro> dicLibri = new Dictionary<int, Libro>();
        Queue<Libro> codaLibri = new Queue<Libro>();
        Stack<Libro> pilaLibri = new Stack<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAggiungiLibro_Click(object sender, EventArgs e)
        {
            Libro l;

            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            dicLibri.Add(pos++, l);
        }

        private void btnVisLibri_Click(object sender, EventArgs e)
        {
            foreach (int key in dicLibri.Keys)
                MessageBox.Show("Chiave: " + key);
            foreach (Libro l in dicLibri.Values)
                MessageBox.Show(l.titolo + " - " + l.autore);
        }

        private void btnVisPos_Click(object sender, EventArgs e)
        {
            Libro l = dicLibri[Convert.ToInt32(posNupdown.Value)];
            MessageBox.Show("Libro in posizione" + posNupdown.Value + ": \n" + "Titolo: " + l.titolo + " - Autore: " + l.autore);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEstraiCoda_Click(object sender, EventArgs e)
        {
            Libro l = codaLibri.Dequeue();
            MessageBox.Show("Libro estratto-> \nTitolo: " + l.titolo + " - Autore: "+l.autore);
        }

        private void btnAddCoda_Click(object sender, EventArgs e)
        {
            Libro l;

            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            codaLibri.Enqueue(l);
        }

        private void btnAddLibroPila_Click(object sender, EventArgs e)
        {
            Libro l;

            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            pilaLibri.Push(l);
        }

        private void btnEstraiLibroPila_Click(object sender, EventArgs e)
        {
            Libro l = pilaLibri.Pop();
            MessageBox.Show("Libro estratto-> \nTitolo: " + l.titolo + " - Autore: " + l.autore);
        }
    }
}
