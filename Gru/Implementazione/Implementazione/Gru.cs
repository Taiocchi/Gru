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

        private Stazione stazione;

        public Stazione Stazione
        {
            get { return stazione; }
            set { stazione = value; }
        }
        public int AltezzaBraccio
        {
            get { return altezzaBraccio; }
            set 
            { 
                if (value <= AltezzaMinima && value >= AltezzaMassima)
                    altezzaBraccio = value; 
            }
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
            set 
            {
                if (value >= 170 && value <= 420)
                    altezzaMassima = value; 
            }
        }

        public int AltezzaMinima
        {
            get { return altezzaMinima; }
            set
            {
                if (value >= 170 && value <= 420)
                    altezzaMinima = value;
            }
        }


        public void alzaBraccio()
        {
            if (AltezzaBraccio - 10 >= AltezzaMassima)
                AltezzaBraccio -= 10;
        }

        public void abbassaBraccio()
        {
            if (AltezzaBraccio + 10 <= AltezzaMinima)
                AltezzaBraccio += 10;
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
            this.altezzaBraccio = altezzaMassima;
        }
    }
}
