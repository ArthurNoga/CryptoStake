namespace CryptoStake_v3.Domaine
{
    class Crypto
    {

        private static double marge = 0.05;
        private string id { get; }
        private string nom { get; }
        private double prixAch { get; }
        private double prixVen { get; }
        private double evol { get; }
        public Crypto(string id, string nom, float prixAch, float evol)
        {

            this.id = id; this.nom = nom; this.prixAch = prixAch; this.prixVen = prixAch - prixAch * marge; this.evol = evol;

        }
    }
}
