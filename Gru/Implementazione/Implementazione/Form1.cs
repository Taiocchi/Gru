namespace Implementazione
{
    public partial class Form1 : Form
    {
        private Gru gru;
        private Stazione stazione;

        public Form1()
        {
            InitializeComponent();
            Gru gru1 = null;
            gru1 = new Gru("1", "1", 3, 2, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1200, 700);
        }

        private void Alza_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Abbassa_Click(object sender, EventArgs e)
        {

        }
    }
}
