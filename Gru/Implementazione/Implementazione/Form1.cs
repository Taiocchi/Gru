namespace Implementazione
{
    public partial class Form1 : Form
    {
        private Gru gru1;
        private Stazione stazione1;

        public Form1()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitializeComponent();

            gru1 = new Gru("1", "1", 3, 170, 420);

            stazione1 = new Stazione("1", gru1);

            gru1.Stazione = stazione1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1200, 700);
        }

        private void Alza_Click(object sender, EventArgs e)
        {
            stazione1.alzaBraccio();
            AggiornaInterfaccia();
        }

        private void Abbassa_Click(object sender, EventArgs e)
        {
            stazione1.abbassaBraccio();
            AggiornaInterfaccia();
        }
        private void Posizione_Sicurezza_Click(object sender, EventArgs e)
        {
            stazione1.posizioneSicurezza();
            AggiornaInterfaccia();
        }
        private void Applica_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Altezza_Minima.Text) <= Convert.ToInt32(Altezza_Massima.Text))
            {
                gru1.AltezzaMassima = 700 - Convert.ToInt32(Altezza_Massima.Text);
                gru1.AltezzaMinima = 700 - Convert.ToInt32(Altezza_Minima.Text);

                if (gru1.AltezzaBraccio < gru1.AltezzaMassima)
                    gru1.AltezzaBraccio = gru1.AltezzaMassima;
                else if (gru1.AltezzaBraccio > gru1.AltezzaMinima)
                    gru1.AltezzaBraccio = gru1.AltezzaMinima;

                AggiornaInterfaccia();
            }
            else
            {
                MessageBox.Show("ERRORE!! -- L'altezza minima � maggiore di quella massima!!");
            }
        }
        private void AggiornaInterfaccia()
        {
            Gancio.Top = gru1.AltezzaBraccio;
        }
    }
}
