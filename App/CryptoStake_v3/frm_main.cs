using MetroFramework;
using MetroFramework.Forms;
using System;
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
            LblUsrload();



            ChartLoader();
        }







        private void LblUsrload()
        {
            //recuperer nom utilisateur etcharger dans lbl_User
            //
            //User usr=User.GetInstance()
            //String rtn =usr.GetPrenom+" "+usr.GetNom()
            String rtn = "Arthur Noguera-Augey";
            lbl_Usr.Text = rtn;

        }

        // Portfolio



        private void ChartLoader()
        {
            //TODO examination du portfolio sur table compte et transaction(cursor? valeurs chaque coin)
            ChartPortfolio.Series["portfolio"].Points.AddXY("btc", 1300);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Eth", 800);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Xrp", 10000);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Ada", 4000);
        }

        private void dtg_portfolio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cbo_portfolio.value= valeur de la case cliqué
        }

        //charger comboBox ac les transaction du portfolio
        private void btn_vendre_Click(object sender, EventArgs e)
        {
            //query vente de la position
            MetroMessageBox.Show(this, "La transaction s'est deroulé correctement, votre compte a ete credite +/valeurTransaction", "Vente Effectué", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //Achat

        private void Btn_achatValider_Click(object sender, EventArgs e)
        {
            //les test solde suffisant pour la trasaction si achat
            //click sur la recherche
            //si vente ou achat

            if (txt_AchatSearch.Text == "" || nud_achatQuant.Value == 0)
            {
                MetroMessageBox.Show(this, "Choisissez un Assets et une quantité", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



            //TODO: verifier si le solde est sufisant 
            //TODO : query check solde du compte

            //MetroMessageBox.Show(this, "Approvisionner votre Compte", "Solde insufisant", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);




            if (txt_AchatSearch.Text != "" & nud_achatQuant.Value > 0)
            {
                MetroMessageBox.Show(this, "Vous venez d'acheter de la cryptomonnaies :" + nud_achatQuant.Value + " unités de " + txt_AchatSearch.Text, "Achat Validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else if (chk_achatSl.Checked == true || chk_TP.Checked == true)
            {
                if (nud_slTpVal.Value == 0)
                {
                    MetroMessageBox.Show(this, "Veuillez choisir un pourcentage pour votre Stop loss/Take profit", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }



        }

        private void dtg_transac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_achatSearch.Text= valeur de la case cliqué
        }

        private void Chk_TP_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_achatSl.Checked) { chk_achatSl.Checked = false; }
        }

        private void Chk_achatSl_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TP.Checked) { chk_TP.Checked = false; }
        }


        //facture

        private void btn_printAnnuel_Click(object sender, EventArgs e)
        {
            //query recurper list de transaction, instanciation Facture -> preview
        }

        private void bnt_printMensuel_Click(object sender, EventArgs e)
        {
            //query recurper list de transaction, instanciation Facture -> preview
        }

        private void btn_printHebdo_Click(object sender, EventArgs e)
        {
            //query recurper list de transaction, instanciation Facture -> preview
        }


        private void dtg_facture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_facture.Text= valeur de la case cliqué
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Voici la facture pour /typeFacture ou transaction", "Impression de Facture", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }



        //miscellaneous


        private void ClearTransac() {
            nud_slTpVal.Value = 0;
            nud_achatQuant.Value = 0;
            chk_achatSl.Checked = false;
            chk_TP.Checked = false;
        }






        //navigation

        private void Btn_homeMain_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_home;
            ClearTransac();
        }

        private void Btn_achatVente_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_shop;
            ClearTransac();
        }

        private void Btn_facture_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_facture;
            ClearTransac();
        }


        private void Btn_walletMain_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_wallet;
            ClearTransac();

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

    
    }
}
