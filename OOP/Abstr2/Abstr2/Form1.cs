namespace Abstr2
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

        private void btnLanciaDado_Click(object sender, EventArgs e)
        {
            Dado d = new Dado();

            d.Lancio();

            MessageBox.Show("Risultato: " + d.N);
        }

        private void btnLanciaMoneta_Click(object sender, EventArgs e)
        {
            Moneta n = new Moneta();
            n.Lancio();
            MessageBox.Show("Moneta: " + ((n.V == 0) ? "Testa" : "Croce"));
        }

        private void btnLanciaDadoAbstr_Click(object sender, EventArgs e)
        {
            DadoAbstr d = new DadoAbstr();

            d.Lancio();

            MessageBox.Show("Risultato: " + d.X);
        }

        private void btnLanciaMonetaAbstr_Click(object sender, EventArgs e)
        {
            MonetaAbstr n = new MonetaAbstr();
            n.Lancio();
            MessageBox.Show("Moneta: " + ((n.X == 0) ? "Testa" : "Croce"));
        }
    }
}