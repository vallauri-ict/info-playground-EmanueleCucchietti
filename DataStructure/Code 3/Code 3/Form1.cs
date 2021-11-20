using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        int max=0, min=100;
        public struct pazienti
        {
            public string nome;
            public int eta;
            public int temperatura;
            public string color;
        }
        Dictionary<string, Queue<pazienti>> dictColors = new Dictionary<string, Queue<pazienti>>();
        Queue<pazienti> pazientiRosso = new Queue<pazienti>();
        Queue<pazienti> pazientiGiallo = new Queue<pazienti>();
        Queue<pazienti> pazientiVerde = new Queue<pazienti>();
        Queue<pazienti> pazientiBianco = new Queue<pazienti>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dictColors["Rosso"] = pazientiRosso;
            dictColors["Giallo"] = pazientiGiallo;
            dictColors["Verde"] = pazientiVerde;
            dictColors["Bianco"] = pazientiBianco;
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Queue<pazienti> patients = null;
            patients = dictColors[cmbColore.GetItemText(cmbColore.SelectedItem)];
            insertPatient(patients);
            modifyMaxMinTemperatures();
            clearFields();
        }

        private void modifyMaxMinTemperatures()
        {
            if(nmUDtemp.Value > max)
            {
                max = Convert.ToInt32(nmUDtemp.Value);
                lblTMax.Text = "Temperatura Massima del Giorno: " + max.ToString();
            }
            else if(nmUDtemp.Value < min)
            {
                min = Convert.ToInt32(nmUDtemp.Value);
                lblTMin.Text = "Temperatura Minima del Giorno: " + min.ToString();
            }
        }

        private void btnPreleva_Click(object sender, EventArgs e)
        {
            bool passed = false;
            Queue<pazienti> patients;
            foreach(Queue<pazienti> patn in dictColors.Values)
            {
                if(patn.Count > 0)
                {
                    prelevaPaziente(patn);
                    return ;
                }
            }
            if(!passed)
            {
                MessageBox.Show("Non sono presenti pazienti");
                return ;
            }
        }
        private void prelevaPaziente(Queue<pazienti> patients)
        {
            pazienti patient;
            patient = patients.Dequeue();
            MessageBox.Show(
                "Il paziente prelevato è: \n"
                +
                "Nome: " + patient.nome + "\n"
                +
                "Età: " + patient.eta + "\n"
                +
                "Temperatura: " + patient.temperatura + "\n"
                +
                "Codice colore: " + patient.color +"\n"
                );
        }
        private void insertPatient(Queue<pazienti> patients)
        {
            pazienti patient = new pazienti();
            patient.nome = txtNome.Text;
            patient.eta = Convert.ToInt32(txtEta.Text);
            patient.temperatura = Convert.ToInt32(nmUDtemp.Value);
            patient.color = cmbColore.GetItemText(cmbColore.SelectedItem);

            patients.Enqueue(patient);
        }
        private void clearFields()
        {
            txtNome.Text = "";
            txtEta.Text = "";
            nmUDtemp.Value = 37;
        }
    }
}
