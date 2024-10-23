namespace Implementazione
{
    internal class Gru
    {
        private string numeroSeriale;
        private string produttore;
        private int pesoMassimo;
        private int altezzaMassima;
        private int altezzaMinima;
        private int altezzaBraccio;

        public int AltezzaBraccio
        {
            get { return altezzaBraccio; }
            set { altezzaBraccio = value; }
        }
        public string NumeroSeriale
        {
            get { return numeroSeriale; }
        }

        public string Produttore
        {
            get { return produttore; }
        }

        public int PesoMassimo
        {
            get { return pesoMassimo; }
        }

        public int AltezzaMassima
        {
            get { return altezzaMassima; }
            set { altezzaMassima = value; }
        }

        public int AltezzaMinima
        {
            get { return altezzaMinima; }
            set { altezzaMinima = value; }
        }


        public void alzaBraccio()
        {
            AltezzaBraccio +=20;
        }

        public void abbassaBraccio()
        {
            AltezzaBraccio -=20;
        }

        public void posizioneSicurezza()
        {
            AltezzaBraccio = AltezzaMinima;
        }


        public Gru(string numeroSeriale, string produttore, int pesoMassimo, int altezzaMassima, int altezzaMinima)
        {
            this.numeroSeriale = numeroSeriale;
            this.produttore = produttore;
            this.pesoMassimo = pesoMassimo;
            this.altezzaMassima = altezzaMassima;
            this.altezzaMinima = altezzaMinima;
            this.altezzaBraccio = altezzaMinima;
        }
    }
}
