using CryptoStake_v3.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Threading;
using System.Windows.Forms;


namespace CryptoStake_v3
{
    public partial class Frm_main : MetroForm
    {
        public Frm_main()
        {
            InitializeComponent();


        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            btn_homeMain.Focus();

            ChartLoader();
        }

  




     

    



        private void ChartLoader()
        {
            //TODO examination du portfolio sur table compte et transaction(cursor? valeurs chaque coin)
            ChartPortfolio.Series["portfolio"].Points.AddXY("btc", 1300);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Eth", 800);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Xrp", 10000);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Ada", 4000);
        }


        private void Btn_validTransac_Click(object sender, EventArgs e)
        {
            //les test solde suffisant pour la trasaction si achat
            //click sur la recherche
            //si vente ou achat
            
          
            if(txt_achatVente.Text=="ok"||nud_quantTransac.Value==0)
                MetroMessageBox.Show(this, "Choisissez un Assets et une quantité", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //TODO: verifier si le solde est insufisant ici emulation 
            //TODO : query check solde du compte
            if (txt_achatVente.Text == "error" || nud_quantTransac.Value == 1 & chk_achatVente.Items.Equals("Achat") ){

                MetroMessageBox.Show(this, "Approvisionner votre Compte", "Solde insufisant", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }

        //navigation

        private void Btn_homeMain_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_home;
        }

        private void Btn_achatVente_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_shop;
        }

        private void Btn_facture_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_facture;
        }


        private void Btn_walletMain_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_wallet;

        }
        //quitter Deconnexion


        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Frm_Login log = new Frm_Login();
            this.Hide();
            log.ShowDialog();

        }
        private void Btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pnl_achat_vente_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
