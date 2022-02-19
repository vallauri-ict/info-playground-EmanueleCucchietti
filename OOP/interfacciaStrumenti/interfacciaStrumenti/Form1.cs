namespace interfacciaStrumenti
{
    public partial class Form1 : Form
    {
        Complesso cmp = new Complesso();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRumorista_Click(object sender, EventArgs e)
        {
            Rumorista r = new Rumorista();
            cmp.aggiungiRumorista(r);
        }

        private void btnChitarra_Click(object sender, EventArgs e)
        {
            Chitarra chitarra = new Chitarra();
            cmp.aggiungiStrumento(chitarra);
        }

        private void btnTromba_Click(object sender, EventArgs e)
        {
            Tromba tromba = new Tromba();
            cmp.aggiungiStrumento(tromba);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            cmp.Play();
        }
    }
}