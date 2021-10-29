namespace CryptoStake_v3.Domaine
{
    class Crypto
    {

        private static double marge = 0.05;
        public string id { get; }
        public string nom { get; }
        public double prixAch { get; }
        public double prixVen { get; }
        public double evol { get; }
        public Crypto(string id, string nom, double prixAch, double evol)
        {

            this.id = id; this.nom = nom; this.prixAch = prixAch; this.prixVen = prixAch - prixAch * marge; this.evol = evol;

        }
    }
}
