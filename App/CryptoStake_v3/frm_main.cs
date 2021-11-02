using CryptoStake_v3.Services;
using MetroFramework.Forms;
using System;
using System.Threading;
using System.Windows.Forms;


namespace CryptoStake_v3
{
    public partial class frm_main : MetroForm
    {
        public frm_main()
        {
            InitializeComponent();


        }

        private void frm_main_Load(object sender, EventArgs e)
        {
       

            ChartLoader();
        }

  




     

    



        private void ChartLoader()
        {
            //TODO examination du portfolio sur table compte et transaction(cursor? valeurs chaque coin)
            chart1.Series["portfolio"].Points.AddXY("btc", 1300);
            chart1.Series["portfolio"].Points.AddXY("Eth", 800);
            chart1.Series["portfolio"].Points.AddXY("Xrp", 10000);
            chart1.Series["portfolio"].Points.AddXY("Ada", 4000);
        }


        private void btn_validTransac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la transaction c est deroulé correctement");
        }

       //navigation

        private void bnt_homeMain_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_home;
        }

        private void btn_achatVente_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_shop;
        }

        private void btn_facture_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_facture;
        }


        private void btn_walletMain_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_wallet;

        }
        //quitter Deconnexion


        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            this.Hide();
            log.ShowDialog();

        }
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_achat_vente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
