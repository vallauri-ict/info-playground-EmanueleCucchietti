namespace Abstr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAreaCilindro_Click(object sender, EventArgs e)
        {
            Cilindro c = new Cilindro(Convert.ToInt32(txtRaggio.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(c.StampaArea());
        }

        private void btnVolumeCilindro_Click(object sender, EventArgs e)
        {
            Cilindro c = new Cilindro(Convert.ToInt32(txtRaggio.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(c.StampaVolume());
        }
    }
}