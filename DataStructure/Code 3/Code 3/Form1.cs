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
            Queue<pazienti> patients = null;
            switch (cmbColore.GetItemText(cmbColore.SelectedItem))
            {
                case "Rosso":
                    patients = pazientiRosso;
                    break;
                case "Giallo":
                    patients = pazientiGiallo;
                    break;
                case "Verde":
                    patients = pazientiVerde;
                    break;
                case "Bianco":
                    patients = pazientiBianco;
                    break;
            }
            insertPatient(patients);
            clearFields();
        }

        private void clearFields()
        {
            txtNome.Text = "";
            txtEta.Text = "";
            nmUDtemp.Value = 37;
        }
        private void insertPatient(Queue<pazienti> patients)
        {
            pazienti patient = new pazienti();
            patient.nome = txtNome.Text;
            patient.eta = Convert.ToInt32(txtEta.Text);
            patient.temperatura = Convert.ToInt32(nmUDtemp.Value);

            patients.Enqueue(patient);
        }
        private void btnPreleva_Click(object sender, EventArgs e)
        {
            string color = "";
            Queue<pazienti> patients;
            if (pazientiRosso.Count > 0)
            {
                patients = pazientiRosso;
                color = "Rosso";
            }
            else if (pazientiGiallo.Count > 0)
            {
                patients = pazientiGiallo;
                color = "Giallo";
            }
            else if (pazientiVerde.Count > 0)
            {
                patients = pazientiVerde;
                color = "Verde";
            }
            else if (pazientiBianco.Count > 0)
            {
                patients = pazientiBianco;
                color = "Bianco";
            }
            else
            {
                MessageBox.Show("Non sono presenti pazienti");
                return ;
            }
            prelevaPaziente(patients,color);
        }
        private void prelevaPaziente(Queue<pazienti> patients, string color)
        {
            pazienti patient;
            patient = patients.Dequeue();
            MessageBox.Show(
                "Il paziente prelevato è: \n"
                +
                patient.nome
                +
                patient.eta
                +
                patient.temperatura
                +
                color
                );
        }
    }
}
