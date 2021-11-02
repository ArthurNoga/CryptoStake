using CryptoStake_v3.Services;
using MetroFramework.Forms;
using System;
using System.Data;
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
            // TODO: This line of code loads data into the 'home.CRYPTO' table. You can move, or remove it, as needed.
            this.cRYPTOTableAdapter.Fill(this.home.CRYPTO);

            // Chargement des valeurs depuis l api et rafraichiessment toute les 15 sec
            JDBC database = JDBC.GetInstance();
            database.InsertCryptos();
            new Thread(() =>
               {
                   while (true)
                   {
                       database.InsertCryptos();
                       Thread.Sleep(15000);
                   }
               }).Start();


            ChartLoader();
        }

        private void tbc_main_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void btn_walletMain_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_wallet;

        }

        private void v_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_shop;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_facture;
        }



        private void ChartLoader()
        {

            chart1.Series["portfolio"].Points.AddXY("btc", 1300);
            chart1.Series["portfolio"].Points.AddXY("Eth", 800);
            chart1.Series["portfolio"].Points.AddXY("Xrp", 10000);
            chart1.Series["portfolio"].Points.AddXY("Ada", 4000);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btn_validTransac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la transaction c est deroulé correctement");
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            this.Hide();
            log.ShowDialog();

        }

        private void bnt_homeMain_Click(object sender, EventArgs e)
        {


            tbc_Main.SelectedTab = tbp_home;

        }

        private void txt_searchMain_TextChanged(object sender, EventArgs e)
        {
            
           
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRYPTOTableAdapter.FillBy(this.home.CRYPTO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
