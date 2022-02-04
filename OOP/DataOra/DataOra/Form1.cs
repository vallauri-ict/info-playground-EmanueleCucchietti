namespace DataOra
{
    public partial class Form1 : Form
    {
        Data data;
        DataOra dataOra;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = new Data();
            MessageBox.Show(data.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data = new Data((int)nmGiorno.Value, (int)nmMese.Value, (int)nmAnno.Value);
            nmGiorno2.Value = nmGiorno.Value;
            nmMese2.Value = nmMese.Value;
            nmAnno2.Value = nmAnno.Value;
            MessageBox.Show(data.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            nmGiorno.Value = nmGiorno2.Value;
            nmMese.Value = nmMese2.Value;
            nmAnno.Value = nmAnno2.Value;
            data.scrivi((int)nmGiorno2.Value, (int)nmMese2.Value, (int)nmAnno2.Value);
            MessageBox.Show(data.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataOra = new DataOra();
            MessageBox.Show(dataOra.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataOra = new DataOra((int)nmGiorno3.Value, (int)nmMese3.Value, (int)nmAnno3.Value, (int)nmOre.Value, (int)nmMinuti.Value, (int)nmSecondi.Value);
            nmGiorno4.Value = nmGiorno3.Value;
            nmMese4.Value = nmMese3.Value;
            nmAnno4.Value = nmAnno3.Value;
            nmOre2.Value = nmOre.Value;
            nmMinuti2.Value = nmMinuti.Value;
            nmSecondi2.Value = nmSecondi.Value;
            MessageBox.Show(dataOra.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nmGiorno3.Value = nmGiorno4.Value;
            nmMese3.Value = nmMese4.Value;
            nmAnno3.Value = nmAnno4.Value;
            nmOre.Value = nmOre2.Value;
            nmMinuti.Value = nmMinuti2.Value;
            nmSecondi.Value = nmSecondi2.Value;
            dataOra.scrivi((int)nmGiorno4.Value, (int)nmMese4.Value, (int)nmAnno4.Value, (int)nmOre2.Value, (int)nmMinuti2.Value, (int)nmSecondi2.Value);
            MessageBox.Show(dataOra.ToString());
        }
    }
}