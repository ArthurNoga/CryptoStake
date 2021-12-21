﻿using CryptoStake_v3.Services;
using MetroFramework;
using MetroFramework.Forms;
using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;


namespace CryptoStake_v3
{
    public partial class Frm_main : MetroForm
    {
        ODBC database = ODBC.GetInstance();
        public Frm_main()
        {
            InitializeComponent();

            
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            
            
           btn_homeMain.Focus();
           LblUsrload();
           ChartLoader();
           FillMainDatagrid();
           FillPortFolio(10);
           FillAchatDatagrid();
        }


        private void LblUsrload()
        {
            //recuperer nom utilisateur etcharger dans lbl_User
            //
            //User usr=User.GetInstance()
            //String rtn =usr.GetPrenom+" "+usr.GetNom()
            String rtn = "Arthur Noguera-Augey";
        
        }

        // Portfolio



        private void ChartLoader()
        {
            //TODO query  sel * from transaction where compt_Id=transc_comptID 
            //foreach(  transaction-> ChartPortfolio.Series["portfolio"].Points.AddXY("Crypt_ID", 1300);
            ChartPortfolio.Series["portfolio"].Points.AddXY("btc", 1300);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Eth", 800);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Xrp", 10000);
            ChartPortfolio.Series["portfolio"].Points.AddXY("Ada", 4000);
        }

        private void Dtg_portfolio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cbo_portfolio.value= valeur de la case cliqué
        }


        private void Btn_portFvendre_Click(object sender, EventArgs e)
        {
            if (cbo_portFcrypoList.Text == "") { MetroMessageBox.Show(this, "Vous n avez pas choisis la position que vous souhaitez vendre", "Choisissez une postion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                MetroMessageBox.Show(this, "La transaction s'est deroulé correctement, votre compte a ete credite +/valeurTransaction", "Vente Effectué", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }




        //Achat

        private void Btn_achatValider_Click(object sender, EventArgs e)
        {
            //les test solde suffisant pour la trasaction si achat
            //click sur la recherche
            //si vente ou achat

            if (txt_achatSearch.Text == "" || nud_achatQuant.Value == 0)
            {
                MetroMessageBox.Show(this, "Choisissez un Assets et une quantité", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_achatSearch.Focus();
            }

            else if ((chk_achatSl.Checked == true || chk_achatTP.Checked == true)& nud_achatSlTpVal.Value == 0)
            {
                
                    MetroMessageBox.Show(this, "Veuillez choisir un pourcentage pour votre Stop loss/Take profit", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nud_achatSlTpVal.Focus();
               
            }

            //TODO: verifier si le solde est sufisant 
            //TODO : query check solde du compte

            //MetroMessageBox.Show(this, "Approvisionner votre Compte", "Solde insufisant", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                    MetroMessageBox.Show(this, "Vous venez d'acheter de la cryptomonnaies :" + nud_achatQuant.Value + " unités de " + txt_achatSearch.Text, "Achat Validé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void Dtg_transac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_achatSearch.Text= valeur de la case cliqué
            txt_achatSearch.Text = dtg_transac.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

        private void Chk_achatTP_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_achatSl.Checked) { chk_achatSl.Checked = false; }
            nud_achatSlTpVal.Value = 0;
        }

        private void Chk_achatSl_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_achatTP.Checked) { chk_achatTP.Checked = false; }
            nud_achatSlTpVal.Value = 0;
        }


        //facture
        //(TODO implementation class abstaite->4  class concrete(transac, transcs mensuel,transacs mensuel,transacs hebdo)

        private void Btn_facturePrintAnnuel_Click(object sender, EventArgs e)
        {
            //query recurper list de transaction, instanciation FactureAnnuel -> preview
        }

        private void Btn_facturePrintMensuel_Click(object sender, EventArgs e)
        {
            //query recurper list de transaction, instanciation FactureMensuel -> preview
        }

        private void Btn_facturePrintHebdo_Click(object sender, EventArgs e)
        {
            //query recurper list de transaction, instanciation FactureHebdomadaire -> preview
        }


        private void Dtg_facture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_facture.Text= valeur de la case cliqué
        }
        private void Btn_facturePrint_Click(object sender, EventArgs e)
        {

            //TODO verifier que preview n est pas vide
            MetroMessageBox.Show(this, "Voici la facture pour /typeFacture ou transaction", "Impression de Facture", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }










        //fill Datagrids

        public void FillMainDatagrid()
        {

            OracleConnection con = new OracleConnection("USER ID=SYSTEM;;Password=AZertyui21!;Data Source= localhost:1521 / XE; PERSIST SECURITY INFO = True");

            con.Open();

            String sql = " Select * from cryptostake_data.vw_mainpage";
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dtg_Home.DataSource = ds.Tables[0];
         
        }

        public void FillPortFolio(int persID)
        {
            OracleConnection con = new OracleConnection(ODBC.ConnectionString);
            con.Open();
            String sql = "Select transac_crypt_id as Id, transac_date as Dates, transac_quantite as Quantité, transac_type as Type, transac_prix as Valeur from Cryptostake_data.cryp_transac join Cryptostake_data.cryp_compte on transac_compt_id = compt_id join Cryptostake_data.cryp_pers on compt_pers_id = pers_id where pers_id =" + persID;
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtg_portfolio.DataSource = ds.Tables[0];
        }




        public void FillAchatDatagrid()
        {

            OracleConnection con = new OracleConnection(ODBC.ConnectionString);

            con.Open();

            String sql = " Select * from cryptostake_data.vw_achat";
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dtg_transac.DataSource = ds.Tables[0];

        }

        public void FillAchatDatagrid2()
        {

            (dtg_transac.DataSource as DataTable).DefaultView.RowFilter = string.Format("crypt_nom = '{0}'", txt_achatSearch.Text);
        }















        //miscellaneous


        private void ClearTransac() {
            nud_achatSlTpVal.Value = 0;
            nud_achatQuant.Value = 0;
            chk_achatSl.Checked = false;
            chk_achatTP.Checked = false;
            txt_achatSearch.Text = "";
        }

        private void ClearSearches()
        {
            txt_achatSearch.Text = "";
            txt_factureSearch.Text = "";
            txt_homeSearch.Text = "";
            txt_portFsearch.Text = "";
        }





        //navigation

        private void Btn_homeMain_Click(object sender, EventArgs e)
        {
            tbc_main.SelectedTab = tbp_home;
            ClearTransac();
            ClearSearches(); 
            txt_homeSearch.Focus();
            //TODO update database
            database.InsertALLCryptosToDB();
        }

        private void Btn_achatVente_Click(object sender, EventArgs e)
        {
                tbc_main.SelectedTab = tbp_shop;
            ClearTransac();
            ClearSearches();
            txt_achatSearch.Focus();
            //TODO update database
            database.InsertALLCryptosToDB();

        }

        private void Btn_facture_Click(object sender, EventArgs e)
        {
            tbc_main.SelectedTab = tbp_facture;
            ClearTransac();
            ClearSearches();
            txt_factureSearch.Focus();
            //TODO update database
            database.InsertALLCryptosToDB();
        }


        private void Btn_walletMain_Click(object sender, EventArgs e)
        {
            tbc_main.SelectedTab = tbp_wallet;
            ClearTransac();
            ClearSearches();
            txt_portFsearch.Focus();
            //TODO update database
            database.InsertALLCryptosToDB();

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

        private void txt_achatSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FillAchatDatagrid2();

                

        }
    }
    }
