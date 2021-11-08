
namespace CryptoStake_v3
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_AJustHeadr = new System.Windows.Forms.Panel();
            this.pnl_menuMain = new System.Windows.Forms.Panel();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.btn_facture = new FontAwesome.Sharp.IconButton();
            this.btn_achatVente = new FontAwesome.Sharp.IconButton();
            this.btn_walletMain = new FontAwesome.Sharp.IconButton();
            this.btn_homeMain = new FontAwesome.Sharp.IconButton();
            this.pnl_ajustTab = new System.Windows.Forms.Panel();
            this.btn_quitter = new FontAwesome.Sharp.IconButton();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.pnl_infoUser = new System.Windows.Forms.Panel();
            this.lbl_Usr = new MetroFramework.Controls.MetroLabel();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.pic_iconUsr = new FontAwesome.Sharp.IconPictureBox();
            this.tbc_main = new System.Windows.Forms.TabControl();
            this.tbp_home = new System.Windows.Forms.TabPage();
            this.pnl_searchHome = new System.Windows.Forms.Panel();
            this.title_home = new MetroFramework.Controls.MetroTile();
            this.lbl_homeSearch = new System.Windows.Forms.Label();
            this.txt_homeSearch = new System.Windows.Forms.TextBox();
            this.dtg_Home = new System.Windows.Forms.DataGridView();
            this.col_dtgHome_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgHome_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgHome_Achat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgHome_Vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgHome_Evol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbp_wallet = new System.Windows.Forms.TabPage();
            this.lbl_portFretourTransac = new System.Windows.Forms.Label();
            this.btn_portFvendre = new System.Windows.Forms.Button();
            this.cbo_portFcrypoList = new MetroFramework.Controls.MetroComboBox();
            this.pnl_chart = new System.Windows.Forms.Panel();
            this.ChartPortfolio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_wallet = new System.Windows.Forms.Panel();
            this.dtg_portfolio = new System.Windows.Forms.DataGridView();
            this.col_dtgPortfolio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgPortfolio_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgPortfolio_buyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgPortfolio_Gain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgPortfolio_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgPortfolio_slTp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_searchPortfolio = new System.Windows.Forms.Panel();
            this.title_portfolio = new MetroFramework.Controls.MetroTile();
            this.lbl_portFsearch = new System.Windows.Forms.Label();
            this.txt_portFsearch = new System.Windows.Forms.TextBox();
            this.tbp_shop = new System.Windows.Forms.TabPage();
            this.dtg_transac = new System.Windows.Forms.DataGridView();
            this.col_dtgTransac_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgTransac_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgTransac_Achat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgTransac_Vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtgTransac_Evol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_searchAchatVente = new System.Windows.Forms.Panel();
            this.lbl_TopScorer = new System.Windows.Forms.Label();
            this.pnl_achat_vente = new System.Windows.Forms.Panel();
            this.title_Achat = new MetroFramework.Controls.MetroTile();
            this.pnl_transacAchat = new System.Windows.Forms.Panel();
            this.txt_achatSearch = new System.Windows.Forms.TextBox();
            this.nud_achatSlTpVal = new System.Windows.Forms.NumericUpDown();
            this.nud_achatQuant = new System.Windows.Forms.NumericUpDown();
            this.btn_achatValider = new System.Windows.Forms.Button();
            this.gpb_slTp = new System.Windows.Forms.GroupBox();
            this.chk_achatSl = new System.Windows.Forms.CheckBox();
            this.chk_achatTP = new System.Windows.Forms.CheckBox();
            this.lbl_achatQuant = new System.Windows.Forms.Label();
            this.lbl_achatSearch = new System.Windows.Forms.Label();
            this.tbp_facture = new System.Windows.Forms.TabPage();
            this.pnl_print = new MetroFramework.Controls.MetroPanel();
            this.prnt_prev_facture = new System.Windows.Forms.PrintPreviewControl();
            this.title_facturation = new MetroFramework.Controls.MetroTile();
            this.pnl_printAction = new System.Windows.Forms.Panel();
            this.btn_facturePrint = new System.Windows.Forms.Button();
            this.pnl_factureCommand = new System.Windows.Forms.Panel();
            this.lbl_factureSearch = new System.Windows.Forms.Label();
            this.txt_factureSearch = new System.Windows.Forms.TextBox();
            this.dtg_facture = new System.Windows.Forms.DataGridView();
            this.col_dtg_facture_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtg_facture_Crypto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtg_facture_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dtg_facture_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_facturePrintHebdo = new System.Windows.Forms.Button();
            this.btn_facturePrintMensuel = new System.Windows.Forms.Button();
            this.btn_facturePrintAnnuel = new System.Windows.Forms.Button();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.pnl_menuMain.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            this.pnl_infoUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_iconUsr)).BeginInit();
            this.tbc_main.SuspendLayout();
            this.tbp_home.SuspendLayout();
            this.pnl_searchHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Home)).BeginInit();
            this.tbp_wallet.SuspendLayout();
            this.pnl_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPortfolio)).BeginInit();
            this.pnl_wallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_portfolio)).BeginInit();
            this.pnl_searchPortfolio.SuspendLayout();
            this.tbp_shop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_transac)).BeginInit();
            this.pnl_searchAchatVente.SuspendLayout();
            this.pnl_achat_vente.SuspendLayout();
            this.pnl_transacAchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_achatSlTpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_achatQuant)).BeginInit();
            this.gpb_slTp.SuspendLayout();
            this.tbp_facture.SuspendLayout();
            this.pnl_print.SuspendLayout();
            this.pnl_printAction.SuspendLayout();
            this.pnl_factureCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_facture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AJustHeadr
            // 
            this.pnl_AJustHeadr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pnl_AJustHeadr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_AJustHeadr.Location = new System.Drawing.Point(84, 46);
            this.pnl_AJustHeadr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_AJustHeadr.Name = "pnl_AJustHeadr";
            this.pnl_AJustHeadr.Size = new System.Drawing.Size(1292, 52);
            this.pnl_AJustHeadr.TabIndex = 2;
            // 
            // pnl_menuMain
            // 
            this.pnl_menuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pnl_menuMain.Controls.Add(this.btn_logout);
            this.pnl_menuMain.Controls.Add(this.btn_facture);
            this.pnl_menuMain.Controls.Add(this.btn_achatVente);
            this.pnl_menuMain.Controls.Add(this.btn_walletMain);
            this.pnl_menuMain.Controls.Add(this.btn_homeMain);
            this.pnl_menuMain.Controls.Add(this.pnl_ajustTab);
            this.pnl_menuMain.Controls.Add(this.btn_quitter);
            this.pnl_menuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menuMain.Location = new System.Drawing.Point(0, 46);
            this.pnl_menuMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_menuMain.Name = "pnl_menuMain";
            this.pnl_menuMain.Size = new System.Drawing.Size(84, 951);
            this.pnl_menuMain.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_logout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logout.IconSize = 36;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_logout.Location = new System.Drawing.Point(0, 819);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(84, 66);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // btn_facture
            // 
            this.btn_facture.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_facture.FlatAppearance.BorderSize = 0;
            this.btn_facture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_facture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facture.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.btn_facture.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_facture.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_facture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_facture.IconSize = 36;
            this.btn_facture.Location = new System.Drawing.Point(0, 325);
            this.btn_facture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_facture.Name = "btn_facture";
            this.btn_facture.Size = new System.Drawing.Size(84, 91);
            this.btn_facture.TabIndex = 3;
            this.btn_facture.Text = " ";
            this.btn_facture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_facture.UseVisualStyleBackColor = true;
            this.btn_facture.Click += new System.EventHandler(this.Btn_facture_Click);
            // 
            // btn_achatVente
            // 
            this.btn_achatVente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_achatVente.FlatAppearance.BorderSize = 0;
            this.btn_achatVente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_achatVente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_achatVente.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_achatVente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.btn_achatVente.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btn_achatVente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_achatVente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_achatVente.IconSize = 36;
            this.btn_achatVente.Location = new System.Drawing.Point(0, 234);
            this.btn_achatVente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_achatVente.Name = "btn_achatVente";
            this.btn_achatVente.Size = new System.Drawing.Size(84, 91);
            this.btn_achatVente.TabIndex = 2;
            this.btn_achatVente.Text = " ";
            this.btn_achatVente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_achatVente.UseVisualStyleBackColor = true;
            this.btn_achatVente.Click += new System.EventHandler(this.Btn_achatVente_Click);
            // 
            // btn_walletMain
            // 
            this.btn_walletMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_walletMain.FlatAppearance.BorderSize = 0;
            this.btn_walletMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_walletMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_walletMain.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_walletMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.btn_walletMain.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btn_walletMain.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_walletMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_walletMain.IconSize = 36;
            this.btn_walletMain.Location = new System.Drawing.Point(0, 143);
            this.btn_walletMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_walletMain.Name = "btn_walletMain";
            this.btn_walletMain.Size = new System.Drawing.Size(84, 91);
            this.btn_walletMain.TabIndex = 1;
            this.btn_walletMain.Text = " ";
            this.btn_walletMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_walletMain.UseVisualStyleBackColor = true;
            this.btn_walletMain.Click += new System.EventHandler(this.Btn_walletMain_Click);
            // 
            // btn_homeMain
            // 
            this.btn_homeMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_homeMain.FlatAppearance.BorderSize = 0;
            this.btn_homeMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_homeMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_homeMain.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homeMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.btn_homeMain.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_homeMain.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_homeMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_homeMain.IconSize = 36;
            this.btn_homeMain.Location = new System.Drawing.Point(0, 52);
            this.btn_homeMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_homeMain.Name = "btn_homeMain";
            this.btn_homeMain.Size = new System.Drawing.Size(84, 91);
            this.btn_homeMain.TabIndex = 0;
            this.btn_homeMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_homeMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_homeMain.UseVisualStyleBackColor = true;
            this.btn_homeMain.Click += new System.EventHandler(this.Btn_homeMain_Click);
            // 
            // pnl_ajustTab
            // 
            this.pnl_ajustTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ajustTab.Location = new System.Drawing.Point(0, 0);
            this.pnl_ajustTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_ajustTab.Name = "pnl_ajustTab";
            this.pnl_ajustTab.Size = new System.Drawing.Size(84, 52);
            this.pnl_ajustTab.TabIndex = 3;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_quitter.FlatAppearance.BorderSize = 0;
            this.btn_quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_quitter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_quitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_quitter.IconSize = 36;
            this.btn_quitter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_quitter.Location = new System.Drawing.Point(0, 885);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(84, 66);
            this.btn_quitter.TabIndex = 5;
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.Btn_quitter_Click);
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.pct_logo);
            this.pnl_footer.Controls.Add(this.pnl_infoUser);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(84, 876);
            this.pnl_footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1292, 121);
            this.pnl_footer.TabIndex = 3;
            // 
            // pnl_infoUser
            // 
            this.pnl_infoUser.Controls.Add(this.lbl_Usr);
            this.pnl_infoUser.Controls.Add(this.lbl_welcome);
            this.pnl_infoUser.Controls.Add(this.pic_iconUsr);
            this.pnl_infoUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_infoUser.Location = new System.Drawing.Point(962, 0);
            this.pnl_infoUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_infoUser.Name = "pnl_infoUser";
            this.pnl_infoUser.Size = new System.Drawing.Size(330, 121);
            this.pnl_infoUser.TabIndex = 0;
            // 
            // lbl_Usr
            // 
            this.lbl_Usr.AutoSize = true;
            this.lbl_Usr.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_Usr.Location = new System.Drawing.Point(127, 89);
            this.lbl_Usr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Usr.Name = "lbl_Usr";
            this.lbl_Usr.Size = new System.Drawing.Size(88, 15);
            this.lbl_Usr.TabIndex = 2;
            this.lbl_Usr.Text = "Arthur Noguera";
            this.lbl_Usr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_welcome.Location = new System.Drawing.Point(93, 69);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(140, 15);
            this.lbl_welcome.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Bienvenue sur CryptoStake";
            this.lbl_welcome.UseStyleColors = true;
            // 
            // pct_iconUsr
            // 
            this.pic_iconUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pic_iconUsr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.pic_iconUsr.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.pic_iconUsr.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.pic_iconUsr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pic_iconUsr.IconSize = 72;
            this.pic_iconUsr.Location = new System.Drawing.Point(127, 10);
            this.pic_iconUsr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_iconUsr.Name = "pct_iconUsr";
            this.pic_iconUsr.Size = new System.Drawing.Size(72, 74);
            this.pic_iconUsr.TabIndex = 0;
            this.pic_iconUsr.TabStop = false;
            // 
            // tbc_main
            // 
            this.tbc_main.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbc_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_main.Controls.Add(this.tbp_home);
            this.tbc_main.Controls.Add(this.tbp_wallet);
            this.tbc_main.Controls.Add(this.tbp_shop);
            this.tbc_main.Controls.Add(this.tbp_facture);
            this.tbc_main.Location = new System.Drawing.Point(84, 98);
            this.tbc_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbc_main.Multiline = true;
            this.tbc_main.Name = "tbc_main";
            this.tbc_main.SelectedIndex = 0;
            this.tbc_main.Size = new System.Drawing.Size(1292, 800);
            this.tbc_main.TabIndex = 4;
            // 
            // tbp_home
            // 
            this.tbp_home.Controls.Add(this.pnl_searchHome);
            this.tbp_home.Controls.Add(this.dtg_Home);
            this.tbp_home.Location = new System.Drawing.Point(4, 4);
            this.tbp_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_home.Name = "tbp_home";
            this.tbp_home.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_home.Size = new System.Drawing.Size(1284, 756);
            this.tbp_home.TabIndex = 0;
            this.tbp_home.UseVisualStyleBackColor = true;
            // 
            // pnl_searchHome
            // 
            this.pnl_searchHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pnl_searchHome.Controls.Add(this.title_home);
            this.pnl_searchHome.Controls.Add(this.lbl_homeSearch);
            this.pnl_searchHome.Controls.Add(this.txt_homeSearch);
            this.pnl_searchHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_searchHome.Location = new System.Drawing.Point(4, 5);
            this.pnl_searchHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_searchHome.Name = "pnl_searchHome";
            this.pnl_searchHome.Size = new System.Drawing.Size(1276, 45);
            this.pnl_searchHome.TabIndex = 3;
            // 
            // title_home
            // 
            this.title_home.ActiveControl = null;
            this.title_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.title_home.Location = new System.Drawing.Point(0, 0);
            this.title_home.Name = "title_home";
            this.title_home.Size = new System.Drawing.Size(362, 45);
            this.title_home.TabIndex = 12;
            this.title_home.TabStop = false;
            this.title_home.Text = "Home";
            this.title_home.UseCustomBackColor = true;
            this.title_home.UseSelectable = true;
            // 
            // lbl_homeSearch
            // 
            this.lbl_homeSearch.AutoSize = true;
            this.lbl_homeSearch.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.lbl_homeSearch.Location = new System.Drawing.Point(484, 18);
            this.lbl_homeSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_homeSearch.Name = "lbl_homeSearch";
            this.lbl_homeSearch.Size = new System.Drawing.Size(61, 13);
            this.lbl_homeSearch.TabIndex = 3;
            this.lbl_homeSearch.Text = "rechercher";
            // 
            // txt_homeSearch
            // 
            this.txt_homeSearch.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_homeSearch.Location = new System.Drawing.Point(553, 14);
            this.txt_homeSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_homeSearch.Name = "txt_homeSearch";
            this.txt_homeSearch.Size = new System.Drawing.Size(668, 21);
            this.txt_homeSearch.TabIndex = 0;
            // 
            // dtg_Home
            // 
            this.dtg_Home.AllowUserToAddRows = false;
            this.dtg_Home.AllowUserToDeleteRows = false;
            this.dtg_Home.AllowUserToOrderColumns = true;
            this.dtg_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Home.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Home.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Home.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_Home.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Home.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Home.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dtgHome_id,
            this.col_dtgHome_Nom,
            this.col_dtgHome_Achat,
            this.col_dtgHome_Vente,
            this.col_dtgHome_Evol});
            this.dtg_Home.EnableHeadersVisualStyles = false;
            this.dtg_Home.Location = new System.Drawing.Point(4, 49);
            this.dtg_Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_Home.Name = "dtg_Home";
            this.dtg_Home.ReadOnly = true;
            this.dtg_Home.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_Home.RowHeadersVisible = false;
            this.dtg_Home.Size = new System.Drawing.Size(1257, 713);
            this.dtg_Home.TabIndex = 1;
            this.dtg_Home.TabStop = false;
            // 
            // col_dtgHome_id
            // 
            this.col_dtgHome_id.HeaderText = "ID";
            this.col_dtgHome_id.Name = "col_dtgHome_id";
            this.col_dtgHome_id.ReadOnly = true;
            // 
            // col_dtgHome_Nom
            // 
            this.col_dtgHome_Nom.HeaderText = "Nome";
            this.col_dtgHome_Nom.Name = "col_dtgHome_Nom";
            this.col_dtgHome_Nom.ReadOnly = true;
            // 
            // col_dtgHome_Achat
            // 
            this.col_dtgHome_Achat.HeaderText = "Achat";
            this.col_dtgHome_Achat.Name = "col_dtgHome_Achat";
            this.col_dtgHome_Achat.ReadOnly = true;
            // 
            // col_dtgHome_Vente
            // 
            this.col_dtgHome_Vente.HeaderText = "Vente";
            this.col_dtgHome_Vente.Name = "col_dtgHome_Vente";
            this.col_dtgHome_Vente.ReadOnly = true;
            // 
            // col_dtgHome_Evol
            // 
            this.col_dtgHome_Evol.HeaderText = "% 24h";
            this.col_dtgHome_Evol.Name = "col_dtgHome_Evol";
            this.col_dtgHome_Evol.ReadOnly = true;
            // 
            // tbp_wallet
            // 
            this.tbp_wallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.tbp_wallet.Controls.Add(this.lbl_portFretourTransac);
            this.tbp_wallet.Controls.Add(this.btn_portFvendre);
            this.tbp_wallet.Controls.Add(this.cbo_portFcrypoList);
            this.tbp_wallet.Controls.Add(this.pnl_chart);
            this.tbp_wallet.Controls.Add(this.pnl_wallet);
            this.tbp_wallet.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tbp_wallet.Location = new System.Drawing.Point(4, 4);
            this.tbp_wallet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_wallet.Name = "tbp_wallet";
            this.tbp_wallet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_wallet.Size = new System.Drawing.Size(1284, 774);
            this.tbp_wallet.TabIndex = 1;
            // 
            // lbl_portFretourTransac
            // 
            this.lbl_portFretourTransac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_portFretourTransac.AutoSize = true;
            this.lbl_portFretourTransac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.lbl_portFretourTransac.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_portFretourTransac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.lbl_portFretourTransac.Location = new System.Drawing.Point(432, 738);
            this.lbl_portFretourTransac.Name = "lbl_portFretourTransac";
            this.lbl_portFretourTransac.Size = new System.Drawing.Size(363, 28);
            this.lbl_portFretourTransac.TabIndex = 4;
            this.lbl_portFretourTransac.Text = "Votre portfolio a une Valleur Actuelle de XXXX frs                              \r" +
    "\nVous disposez actuellement de XXXX frs sur votre compte    ";
            this.lbl_portFretourTransac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_portFvendre
            // 
            this.btn_portFvendre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_portFvendre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.btn_portFvendre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_portFvendre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_portFvendre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(123)))), ((int)(((byte)(198)))));
            this.btn_portFvendre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_portFvendre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_portFvendre.Location = new System.Drawing.Point(328, 738);
            this.btn_portFvendre.Name = "btn_portFvendre";
            this.btn_portFvendre.Size = new System.Drawing.Size(98, 28);
            this.btn_portFvendre.TabIndex = 3;
            this.btn_portFvendre.Text = "&Vendre";
            this.btn_portFvendre.UseVisualStyleBackColor = false;
            this.btn_portFvendre.Click += new System.EventHandler(this.Btn_portFvendre_Click);
            // 
            // cbo_portFcrypoList
            // 
            this.cbo_portFcrypoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_portFcrypoList.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbo_portFcrypoList.FormattingEnabled = true;
            this.cbo_portFcrypoList.ItemHeight = 23;
            this.cbo_portFcrypoList.Items.AddRange(new object[] {
            "",
            "bitcoin"});
            this.cbo_portFcrypoList.Location = new System.Drawing.Point(7, 737);
            this.cbo_portFcrypoList.Name = "cbo_portFcrypoList";
            this.cbo_portFcrypoList.Size = new System.Drawing.Size(316, 29);
            this.cbo_portFcrypoList.TabIndex = 2;
            this.cbo_portFcrypoList.UseSelectable = true;
            // 
            // pnl_chart
            // 
            this.pnl_chart.Controls.Add(this.ChartPortfolio);
            this.pnl_chart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_chart.Location = new System.Drawing.Point(827, 5);
            this.pnl_chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_chart.Name = "pnl_chart";
            this.pnl_chart.Size = new System.Drawing.Size(453, 764);
            this.pnl_chart.TabIndex = 1;
            // 
            // ChartPortfolio
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartPortfolio.ChartAreas.Add(chartArea1);
            this.ChartPortfolio.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChartPortfolio.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartPortfolio.Legends.Add(legend1);
            this.ChartPortfolio.Location = new System.Drawing.Point(0, 0);
            this.ChartPortfolio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChartPortfolio.Name = "ChartPortfolio";
            this.ChartPortfolio.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "portfolio";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.ChartPortfolio.Series.Add(series1);
            this.ChartPortfolio.Size = new System.Drawing.Size(453, 764);
            this.ChartPortfolio.TabIndex = 1;
            this.ChartPortfolio.Text = "chart1";
            // 
            // pnl_wallet
            // 
            this.pnl_wallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_wallet.Controls.Add(this.dtg_portfolio);
            this.pnl_wallet.Controls.Add(this.pnl_searchPortfolio);
            this.pnl_wallet.Location = new System.Drawing.Point(0, 0);
            this.pnl_wallet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_wallet.Name = "pnl_wallet";
            this.pnl_wallet.Size = new System.Drawing.Size(808, 741);
            this.pnl_wallet.TabIndex = 0;
            // 
            // dtg_portfolio
            // 
            this.dtg_portfolio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_portfolio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_portfolio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_portfolio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_portfolio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_portfolio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_portfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_portfolio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dtgPortfolio_id,
            this.col_dtgPortfolio_name,
            this.col_dtgPortfolio_buyPrice,
            this.col_dtgPortfolio_Gain,
            this.col_dtgPortfolio_value,
            this.col_dtgPortfolio_slTp});
            this.dtg_portfolio.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtg_portfolio.EnableHeadersVisualStyles = false;
            this.dtg_portfolio.Location = new System.Drawing.Point(0, 45);
            this.dtg_portfolio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_portfolio.Name = "dtg_portfolio";
            this.dtg_portfolio.ReadOnly = true;
            this.dtg_portfolio.RowHeadersVisible = false;
            this.dtg_portfolio.Size = new System.Drawing.Size(808, 685);
            this.dtg_portfolio.StandardTab = true;
            this.dtg_portfolio.TabIndex = 4;
            this.dtg_portfolio.TabStop = false;
            this.dtg_portfolio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_portfolio_CellContentClick);
            // 
            // col_dtgPortfolio_id
            // 
            this.col_dtgPortfolio_id.HeaderText = "Id";
            this.col_dtgPortfolio_id.Name = "col_dtgPortfolio_id";
            this.col_dtgPortfolio_id.ReadOnly = true;
            // 
            // col_dtgPortfolio_name
            // 
            this.col_dtgPortfolio_name.HeaderText = "Name";
            this.col_dtgPortfolio_name.Name = "col_dtgPortfolio_name";
            this.col_dtgPortfolio_name.ReadOnly = true;
            // 
            // col_dtgPortfolio_buyPrice
            // 
            this.col_dtgPortfolio_buyPrice.HeaderText = "Buy";
            this.col_dtgPortfolio_buyPrice.Name = "col_dtgPortfolio_buyPrice";
            this.col_dtgPortfolio_buyPrice.ReadOnly = true;
            // 
            // col_dtgPortfolio_Gain
            // 
            this.col_dtgPortfolio_Gain.HeaderText = "Gain/Perte %";
            this.col_dtgPortfolio_Gain.Name = "col_dtgPortfolio_Gain";
            this.col_dtgPortfolio_Gain.ReadOnly = true;
            // 
            // col_dtgPortfolio_value
            // 
            this.col_dtgPortfolio_value.HeaderText = "Value";
            this.col_dtgPortfolio_value.Name = "col_dtgPortfolio_value";
            this.col_dtgPortfolio_value.ReadOnly = true;
            // 
            // col_dtgPortfolio_slTp
            // 
            this.col_dtgPortfolio_slTp.HeaderText = "Sl/Tp";
            this.col_dtgPortfolio_slTp.Name = "col_dtgPortfolio_slTp";
            this.col_dtgPortfolio_slTp.ReadOnly = true;
            // 
            // pnl_searchPortfolio
            // 
            this.pnl_searchPortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pnl_searchPortfolio.Controls.Add(this.title_portfolio);
            this.pnl_searchPortfolio.Controls.Add(this.lbl_portFsearch);
            this.pnl_searchPortfolio.Controls.Add(this.txt_portFsearch);
            this.pnl_searchPortfolio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_searchPortfolio.Location = new System.Drawing.Point(0, 0);
            this.pnl_searchPortfolio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_searchPortfolio.Name = "pnl_searchPortfolio";
            this.pnl_searchPortfolio.Size = new System.Drawing.Size(808, 45);
            this.pnl_searchPortfolio.TabIndex = 3;
            // 
            // title_portfolio
            // 
            this.title_portfolio.ActiveControl = null;
            this.title_portfolio.Cursor = System.Windows.Forms.Cursors.Default;
            this.title_portfolio.Dock = System.Windows.Forms.DockStyle.Left;
            this.title_portfolio.Location = new System.Drawing.Point(0, 0);
            this.title_portfolio.Name = "title_portfolio";
            this.title_portfolio.Size = new System.Drawing.Size(267, 45);
            this.title_portfolio.TabIndex = 12;
            this.title_portfolio.TabStop = false;
            this.title_portfolio.Text = "Votre Portefolio";
            this.title_portfolio.UseCustomBackColor = true;
            this.title_portfolio.UseSelectable = true;
            // 
            // lbl_portFsearch
            // 
            this.lbl_portFsearch.AutoSize = true;
            this.lbl_portFsearch.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_portFsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.lbl_portFsearch.Location = new System.Drawing.Point(391, 12);
            this.lbl_portFsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_portFsearch.Name = "lbl_portFsearch";
            this.lbl_portFsearch.Size = new System.Drawing.Size(61, 13);
            this.lbl_portFsearch.TabIndex = 0;
            this.lbl_portFsearch.Text = "&rechercher";
            // 
            // txt_portFsearch
            // 
            this.txt_portFsearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_portFsearch.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_portFsearch.Location = new System.Drawing.Point(460, 10);
            this.txt_portFsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_portFsearch.Name = "txt_portFsearch";
            this.txt_portFsearch.Size = new System.Drawing.Size(265, 21);
            this.txt_portFsearch.TabIndex = 1;
            // 
            // tbp_shop
            // 
            this.tbp_shop.Controls.Add(this.dtg_transac);
            this.tbp_shop.Controls.Add(this.pnl_searchAchatVente);
            this.tbp_shop.Controls.Add(this.pnl_achat_vente);
            this.tbp_shop.Location = new System.Drawing.Point(4, 4);
            this.tbp_shop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_shop.Name = "tbp_shop";
            this.tbp_shop.Size = new System.Drawing.Size(1284, 756);
            this.tbp_shop.TabIndex = 2;
            this.tbp_shop.UseVisualStyleBackColor = true;
            // 
            // dtg_transac
            // 
            this.dtg_transac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_transac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_transac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_transac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_transac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_transac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_transac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_transac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dtgTransac_id,
            this.col_dtgTransac_Nom,
            this.col_dtgTransac_Achat,
            this.col_dtgTransac_Vente,
            this.col_dtgTransac_Evol});
            this.dtg_transac.EnableHeadersVisualStyles = false;
            this.dtg_transac.Location = new System.Drawing.Point(362, 44);
            this.dtg_transac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_transac.Name = "dtg_transac";
            this.dtg_transac.ReadOnly = true;
            this.dtg_transac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_transac.RowHeadersVisible = false;
            this.dtg_transac.Size = new System.Drawing.Size(903, 730);
            this.dtg_transac.TabIndex = 5;
            this.dtg_transac.TabStop = false;
            this.dtg_transac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_transac_CellContentClick);
            // 
            // col_dtgTransac_id
            // 
            this.col_dtgTransac_id.HeaderText = "ID";
            this.col_dtgTransac_id.Name = "col_dtgTransac_id";
            this.col_dtgTransac_id.ReadOnly = true;
            // 
            // col_dtgTransac_Nom
            // 
            this.col_dtgTransac_Nom.HeaderText = "Nom";
            this.col_dtgTransac_Nom.Name = "col_dtgTransac_Nom";
            this.col_dtgTransac_Nom.ReadOnly = true;
            // 
            // col_dtgTransac_Achat
            // 
            this.col_dtgTransac_Achat.HeaderText = "Achat";
            this.col_dtgTransac_Achat.Name = "col_dtgTransac_Achat";
            this.col_dtgTransac_Achat.ReadOnly = true;
            // 
            // col_dtgTransac_Vente
            // 
            this.col_dtgTransac_Vente.HeaderText = "Vente";
            this.col_dtgTransac_Vente.Name = "col_dtgTransac_Vente";
            this.col_dtgTransac_Vente.ReadOnly = true;
            // 
            // col_dtgTransac_Evol
            // 
            this.col_dtgTransac_Evol.HeaderText = "% 24h";
            this.col_dtgTransac_Evol.Name = "col_dtgTransac_Evol";
            this.col_dtgTransac_Evol.ReadOnly = true;
            // 
            // pnl_searchAchatVente
            // 
            this.pnl_searchAchatVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pnl_searchAchatVente.Controls.Add(this.lbl_TopScorer);
            this.pnl_searchAchatVente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_searchAchatVente.Location = new System.Drawing.Point(362, 0);
            this.pnl_searchAchatVente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_searchAchatVente.Name = "pnl_searchAchatVente";
            this.pnl_searchAchatVente.Size = new System.Drawing.Size(922, 45);
            this.pnl_searchAchatVente.TabIndex = 2;
            // 
            // lbl_TopScorer
            // 
            this.lbl_TopScorer.AutoSize = true;
            this.lbl_TopScorer.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TopScorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.lbl_TopScorer.Location = new System.Drawing.Point(4, 26);
            this.lbl_TopScorer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TopScorer.Name = "lbl_TopScorer";
            this.lbl_TopScorer.Size = new System.Drawing.Size(130, 13);
            this.lbl_TopScorer.TabIndex = 3;
            this.lbl_TopScorer.Text = "Top scorer de la journée:";
            // 
            // pnl_achat_vente
            // 
            this.pnl_achat_vente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pnl_achat_vente.Controls.Add(this.title_Achat);
            this.pnl_achat_vente.Controls.Add(this.pnl_transacAchat);
            this.pnl_achat_vente.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_achat_vente.Location = new System.Drawing.Point(0, 0);
            this.pnl_achat_vente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_achat_vente.Name = "pnl_achat_vente";
            this.pnl_achat_vente.Size = new System.Drawing.Size(362, 756);
            this.pnl_achat_vente.TabIndex = 0;
            // 
            // title_Achat
            // 
            this.title_Achat.ActiveControl = null;
            this.title_Achat.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Achat.Location = new System.Drawing.Point(0, 0);
            this.title_Achat.Name = "title_Achat";
            this.title_Achat.Size = new System.Drawing.Size(362, 45);
            this.title_Achat.TabIndex = 12;
            this.title_Achat.TabStop = false;
            this.title_Achat.Text = "Achat";
            this.title_Achat.UseCustomBackColor = true;
            this.title_Achat.UseSelectable = true;
            // 
            // pnl_transacAchat
            // 
            this.pnl_transacAchat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.pnl_transacAchat.Controls.Add(this.txt_achatSearch);
            this.pnl_transacAchat.Controls.Add(this.nud_achatSlTpVal);
            this.pnl_transacAchat.Controls.Add(this.nud_achatQuant);
            this.pnl_transacAchat.Controls.Add(this.btn_achatValider);
            this.pnl_transacAchat.Controls.Add(this.gpb_slTp);
            this.pnl_transacAchat.Controls.Add(this.lbl_achatQuant);
            this.pnl_transacAchat.Controls.Add(this.lbl_achatSearch);
            this.pnl_transacAchat.Location = new System.Drawing.Point(32, 163);
            this.pnl_transacAchat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_transacAchat.Name = "pnl_transacAchat";
            this.pnl_transacAchat.Size = new System.Drawing.Size(300, 221);
            this.pnl_transacAchat.TabIndex = 0;
            // 
            // txt_achatSearch
            // 
            this.txt_achatSearch.Location = new System.Drawing.Point(0, 44);
            this.txt_achatSearch.Name = "txt_achatSearch";
            this.txt_achatSearch.Size = new System.Drawing.Size(300, 20);
            this.txt_achatSearch.TabIndex = 0;
            // 
            // nud_achatSlTpVal
            // 
            this.nud_achatSlTpVal.Location = new System.Drawing.Point(0, 163);
            this.nud_achatSlTpVal.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_achatSlTpVal.Name = "nud_achatSlTpVal";
            this.nud_achatSlTpVal.Size = new System.Drawing.Size(297, 20);
            this.nud_achatSlTpVal.TabIndex = 4;
            // 
            // nud_achatQuant
            // 
            this.nud_achatQuant.Location = new System.Drawing.Point(0, 92);
            this.nud_achatQuant.Name = "nud_achatQuant";
            this.nud_achatQuant.Size = new System.Drawing.Size(297, 20);
            this.nud_achatQuant.TabIndex = 1;
            // 
            // btn_achatValider
            // 
            this.btn_achatValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.btn_achatValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_achatValider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_achatValider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_achatValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(123)))), ((int)(((byte)(198)))));
            this.btn_achatValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_achatValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_achatValider.Location = new System.Drawing.Point(0, 189);
            this.btn_achatValider.Name = "btn_achatValider";
            this.btn_achatValider.Size = new System.Drawing.Size(300, 32);
            this.btn_achatValider.TabIndex = 5;
            this.btn_achatValider.Text = "Acheter";
            this.btn_achatValider.UseVisualStyleBackColor = false;
            this.btn_achatValider.Click += new System.EventHandler(this.Btn_achatValider_Click);
            // 
            // gpb_slTp
            // 
            this.gpb_slTp.Controls.Add(this.chk_achatSl);
            this.gpb_slTp.Controls.Add(this.chk_achatTP);
            this.gpb_slTp.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_slTp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.gpb_slTp.Location = new System.Drawing.Point(3, 118);
            this.gpb_slTp.Name = "gpb_slTp";
            this.gpb_slTp.Size = new System.Drawing.Size(294, 39);
            this.gpb_slTp.TabIndex = 2;
            this.gpb_slTp.TabStop = false;
            this.gpb_slTp.Text = "SL/TP";
            // 
            // chk_achatSl
            // 
            this.chk_achatSl.AutoSize = true;
            this.chk_achatSl.Location = new System.Drawing.Point(130, 15);
            this.chk_achatSl.Name = "chk_achatSl";
            this.chk_achatSl.Size = new System.Drawing.Size(73, 17);
            this.chk_achatSl.TabIndex = 3;
            this.chk_achatSl.Text = "Stop loss";
            this.chk_achatSl.UseVisualStyleBackColor = true;
            this.chk_achatSl.CheckedChanged += new System.EventHandler(this.Chk_achatSl_CheckedChanged);
            // 
            // chk_achatTP
            // 
            this.chk_achatTP.AutoSize = true;
            this.chk_achatTP.Location = new System.Drawing.Point(6, 15);
            this.chk_achatTP.Name = "chk_achatTP";
            this.chk_achatTP.Size = new System.Drawing.Size(79, 17);
            this.chk_achatTP.TabIndex = 2;
            this.chk_achatTP.Text = "Take profit";
            this.chk_achatTP.UseVisualStyleBackColor = true;
            this.chk_achatTP.CheckedChanged += new System.EventHandler(this.Chk_achatTP_CheckedChanged);
            // 
            // lbl_achatQuant
            // 
            this.lbl_achatQuant.AutoSize = true;
            this.lbl_achatQuant.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_achatQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.lbl_achatQuant.Location = new System.Drawing.Point(4, 76);
            this.lbl_achatQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_achatQuant.Name = "lbl_achatQuant";
            this.lbl_achatQuant.Size = new System.Drawing.Size(50, 13);
            this.lbl_achatQuant.TabIndex = 1;
            this.lbl_achatQuant.Text = "&Quantité";
            // 
            // lbl_achatSearch
            // 
            this.lbl_achatSearch.AutoSize = true;
            this.lbl_achatSearch.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_achatSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.lbl_achatSearch.Location = new System.Drawing.Point(4, 28);
            this.lbl_achatSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_achatSearch.Name = "lbl_achatSearch";
            this.lbl_achatSearch.Size = new System.Drawing.Size(64, 13);
            this.lbl_achatSearch.TabIndex = 0;
            this.lbl_achatSearch.Text = "&Rechercher";
            // 
            // tbp_facture
            // 
            this.tbp_facture.Controls.Add(this.pnl_print);
            this.tbp_facture.Location = new System.Drawing.Point(4, 4);
            this.tbp_facture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_facture.Name = "tbp_facture";
            this.tbp_facture.Size = new System.Drawing.Size(1284, 756);
            this.tbp_facture.TabIndex = 3;
            this.tbp_facture.UseVisualStyleBackColor = true;
            // 
            // pnl_print
            // 
            this.pnl_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(167)))), ((int)(((byte)(213)))));
            this.pnl_print.Controls.Add(this.prnt_prev_facture);
            this.pnl_print.Controls.Add(this.title_facturation);
            this.pnl_print.Controls.Add(this.pnl_printAction);
            this.pnl_print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_print.HorizontalScrollbarBarColor = true;
            this.pnl_print.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_print.HorizontalScrollbarSize = 15;
            this.pnl_print.Location = new System.Drawing.Point(0, 0);
            this.pnl_print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_print.Name = "pnl_print";
            this.pnl_print.Size = new System.Drawing.Size(1284, 756);
            this.pnl_print.TabIndex = 0;
            this.pnl_print.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnl_print.UseCustomBackColor = true;
            this.pnl_print.VerticalScrollbarBarColor = true;
            this.pnl_print.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_print.VerticalScrollbarSize = 15;
            // 
            // prnt_prev_facture
            // 
            this.prnt_prev_facture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prnt_prev_facture.Location = new System.Drawing.Point(381, 45);
            this.prnt_prev_facture.Name = "prnt_prev_facture";
            this.prnt_prev_facture.Size = new System.Drawing.Size(903, 711);
            this.prnt_prev_facture.TabIndex = 4;
            // 
            // title_facturation
            // 
            this.title_facturation.ActiveControl = null;
            this.title_facturation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.title_facturation.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_facturation.Location = new System.Drawing.Point(381, 0);
            this.title_facturation.Name = "title_facturation";
            this.title_facturation.Size = new System.Drawing.Size(903, 45);
            this.title_facturation.TabIndex = 12;
            this.title_facturation.TabStop = false;
            this.title_facturation.Text = "Facturation et Impression";
            this.title_facturation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_facturation.UseCustomBackColor = true;
            this.title_facturation.UseSelectable = true;
            // 
            // pnl_printAction
            // 
            this.pnl_printAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pnl_printAction.Controls.Add(this.btn_facturePrint);
            this.pnl_printAction.Controls.Add(this.pnl_factureCommand);
            this.pnl_printAction.Controls.Add(this.btn_facturePrintHebdo);
            this.pnl_printAction.Controls.Add(this.btn_facturePrintMensuel);
            this.pnl_printAction.Controls.Add(this.btn_facturePrintAnnuel);
            this.pnl_printAction.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_printAction.Location = new System.Drawing.Point(0, 0);
            this.pnl_printAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_printAction.Name = "pnl_printAction";
            this.pnl_printAction.Size = new System.Drawing.Size(381, 756);
            this.pnl_printAction.TabIndex = 2;
            // 
            // btn_facturePrint
            // 
            this.btn_facturePrint.AutoEllipsis = true;
            this.btn_facturePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.btn_facturePrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_facturePrint.FlatAppearance.BorderSize = 0;
            this.btn_facturePrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_facturePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturePrint.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturePrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_facturePrint.Location = new System.Drawing.Point(0, 691);
            this.btn_facturePrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_facturePrint.Name = "btn_facturePrint";
            this.btn_facturePrint.Size = new System.Drawing.Size(381, 65);
            this.btn_facturePrint.TabIndex = 4;
            this.btn_facturePrint.Text = "Print";
            this.btn_facturePrint.UseVisualStyleBackColor = false;
            this.btn_facturePrint.Click += new System.EventHandler(this.Btn_facturePrint_Click);
            // 
            // pnl_factureCommand
            // 
            this.pnl_factureCommand.Controls.Add(this.lbl_factureSearch);
            this.pnl_factureCommand.Controls.Add(this.txt_factureSearch);
            this.pnl_factureCommand.Controls.Add(this.dtg_facture);
            this.pnl_factureCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_factureCommand.Location = new System.Drawing.Point(0, 255);
            this.pnl_factureCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_factureCommand.Name = "pnl_factureCommand";
            this.pnl_factureCommand.Size = new System.Drawing.Size(381, 501);
            this.pnl_factureCommand.TabIndex = 3;
            // 
            // lbl_factureSearch
            // 
            this.lbl_factureSearch.AutoSize = true;
            this.lbl_factureSearch.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factureSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.lbl_factureSearch.Location = new System.Drawing.Point(30, 231);
            this.lbl_factureSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_factureSearch.Name = "lbl_factureSearch";
            this.lbl_factureSearch.Size = new System.Drawing.Size(61, 13);
            this.lbl_factureSearch.TabIndex = 0;
            this.lbl_factureSearch.Text = "rechercher";
            // 
            // txt_factureSearch
            // 
            this.txt_factureSearch.Location = new System.Drawing.Point(130, 225);
            this.txt_factureSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_factureSearch.Name = "txt_factureSearch";
            this.txt_factureSearch.Size = new System.Drawing.Size(240, 20);
            this.txt_factureSearch.TabIndex = 0;
            // 
            // dtg_facture
            // 
            this.dtg_facture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_facture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_facture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_facture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_facture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dtg_facture_id,
            this.col_dtg_facture_Crypto,
            this.col_dtg_facture_value,
            this.col_dtg_facture_date});
            this.dtg_facture.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_facture.EnableHeadersVisualStyles = false;
            this.dtg_facture.Location = new System.Drawing.Point(0, 0);
            this.dtg_facture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_facture.Name = "dtg_facture";
            this.dtg_facture.ReadOnly = true;
            this.dtg_facture.RowHeadersVisible = false;
            this.dtg_facture.Size = new System.Drawing.Size(381, 215);
            this.dtg_facture.StandardTab = true;
            this.dtg_facture.TabIndex = 5;
            this.dtg_facture.TabStop = false;
            this.dtg_facture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_facture_CellContentClick);
            // 
            // col_dtg_facture_id
            // 
            this.col_dtg_facture_id.HeaderText = "Id";
            this.col_dtg_facture_id.Name = "col_dtg_facture_id";
            this.col_dtg_facture_id.ReadOnly = true;
            // 
            // col_dtg_facture_Crypto
            // 
            this.col_dtg_facture_Crypto.HeaderText = "Crpyto";
            this.col_dtg_facture_Crypto.Name = "col_dtg_facture_Crypto";
            this.col_dtg_facture_Crypto.ReadOnly = true;
            // 
            // col_dtg_facture_value
            // 
            this.col_dtg_facture_value.HeaderText = "Value";
            this.col_dtg_facture_value.Name = "col_dtg_facture_value";
            this.col_dtg_facture_value.ReadOnly = true;
            // 
            // col_dtg_facture_date
            // 
            this.col_dtg_facture_date.HeaderText = "date";
            this.col_dtg_facture_date.Name = "col_dtg_facture_date";
            this.col_dtg_facture_date.ReadOnly = true;
            // 
            // btn_facturePrintHebdo
            // 
            this.btn_facturePrintHebdo.AutoEllipsis = true;
            this.btn_facturePrintHebdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.btn_facturePrintHebdo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_facturePrintHebdo.FlatAppearance.BorderSize = 0;
            this.btn_facturePrintHebdo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_facturePrintHebdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturePrintHebdo.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturePrintHebdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_facturePrintHebdo.Location = new System.Drawing.Point(0, 170);
            this.btn_facturePrintHebdo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_facturePrintHebdo.Name = "btn_facturePrintHebdo";
            this.btn_facturePrintHebdo.Size = new System.Drawing.Size(381, 85);
            this.btn_facturePrintHebdo.TabIndex = 3;
            this.btn_facturePrintHebdo.Text = "Facture hebdomadaire";
            this.btn_facturePrintHebdo.UseVisualStyleBackColor = false;
            this.btn_facturePrintHebdo.Click += new System.EventHandler(this.Btn_facturePrintHebdo_Click);
            // 
            // btn_facturePrintMensuel
            // 
            this.btn_facturePrintMensuel.AutoEllipsis = true;
            this.btn_facturePrintMensuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.btn_facturePrintMensuel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_facturePrintMensuel.FlatAppearance.BorderSize = 0;
            this.btn_facturePrintMensuel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_facturePrintMensuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturePrintMensuel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturePrintMensuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_facturePrintMensuel.Location = new System.Drawing.Point(0, 85);
            this.btn_facturePrintMensuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_facturePrintMensuel.Name = "btn_facturePrintMensuel";
            this.btn_facturePrintMensuel.Size = new System.Drawing.Size(381, 85);
            this.btn_facturePrintMensuel.TabIndex = 2;
            this.btn_facturePrintMensuel.Text = "Facture Mensuel";
            this.btn_facturePrintMensuel.UseVisualStyleBackColor = false;
            this.btn_facturePrintMensuel.Click += new System.EventHandler(this.Btn_facturePrintMensuel_Click);
            // 
            // btn_facturePrintAnnuel
            // 
            this.btn_facturePrintAnnuel.AutoEllipsis = true;
            this.btn_facturePrintAnnuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.btn_facturePrintAnnuel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_facturePrintAnnuel.FlatAppearance.BorderSize = 0;
            this.btn_facturePrintAnnuel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(197)))));
            this.btn_facturePrintAnnuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturePrintAnnuel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturePrintAnnuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.btn_facturePrintAnnuel.Location = new System.Drawing.Point(0, 0);
            this.btn_facturePrintAnnuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_facturePrintAnnuel.Name = "btn_facturePrintAnnuel";
            this.btn_facturePrintAnnuel.Size = new System.Drawing.Size(381, 85);
            this.btn_facturePrintAnnuel.TabIndex = 1;
            this.btn_facturePrintAnnuel.Text = "Facture Annuelle";
            this.btn_facturePrintAnnuel.UseVisualStyleBackColor = false;
            this.btn_facturePrintAnnuel.Click += new System.EventHandler(this.Btn_facturePrintAnnuel_Click);
            // 
            // pct_logo
            // 
            this.pct_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pct_logo.Image = global::CryptoStake_v3.Properties.Resources.facebook_cover_photo_2;
            this.pct_logo.Location = new System.Drawing.Point(0, 0);
            this.pct_logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(962, 121);
            this.pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_logo.TabIndex = 5;
            this.pct_logo.TabStop = false;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1376, 997);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_AJustHeadr);
            this.Controls.Add(this.pnl_menuMain);
            this.Controls.Add(this.tbc_main);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_main";
            this.Padding = new System.Windows.Forms.Padding(0, 46, 0, 0);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CryptoStake";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.pnl_menuMain.ResumeLayout(false);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_infoUser.ResumeLayout(false);
            this.pnl_infoUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_iconUsr)).EndInit();
            this.tbc_main.ResumeLayout(false);
            this.tbp_home.ResumeLayout(false);
            this.pnl_searchHome.ResumeLayout(false);
            this.pnl_searchHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Home)).EndInit();
            this.tbp_wallet.ResumeLayout(false);
            this.tbp_wallet.PerformLayout();
            this.pnl_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartPortfolio)).EndInit();
            this.pnl_wallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_portfolio)).EndInit();
            this.pnl_searchPortfolio.ResumeLayout(false);
            this.pnl_searchPortfolio.PerformLayout();
            this.tbp_shop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_transac)).EndInit();
            this.pnl_searchAchatVente.ResumeLayout(false);
            this.pnl_searchAchatVente.PerformLayout();
            this.pnl_achat_vente.ResumeLayout(false);
            this.pnl_transacAchat.ResumeLayout(false);
            this.pnl_transacAchat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_achatSlTpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_achatQuant)).EndInit();
            this.gpb_slTp.ResumeLayout(false);
            this.gpb_slTp.PerformLayout();
            this.tbp_facture.ResumeLayout(false);
            this.pnl_print.ResumeLayout(false);
            this.pnl_printAction.ResumeLayout(false);
            this.pnl_factureCommand.ResumeLayout(false);
            this.pnl_factureCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_facture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_AJustHeadr;
        private FontAwesome.Sharp.IconButton btn_quitter;
        private System.Windows.Forms.Panel pnl_menuMain;
        private FontAwesome.Sharp.IconButton btn_achatVente;
        private FontAwesome.Sharp.IconButton btn_walletMain;
        private FontAwesome.Sharp.IconButton btn_homeMain;
        private System.Windows.Forms.Panel pnl_ajustTab;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Panel pnl_infoUser;
        private System.Windows.Forms.TabControl tbc_main;
        private System.Windows.Forms.TabPage tbp_home;
        private System.Windows.Forms.TabPage tbp_wallet;
        private System.Windows.Forms.TabPage tbp_shop;
        private System.Windows.Forms.TabPage tbp_facture;
        private FontAwesome.Sharp.IconButton btn_facture;
        private System.Windows.Forms.DataGridView dtg_Home;
        private System.Windows.Forms.Panel pnl_wallet;
        private System.Windows.Forms.Panel pnl_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPortfolio;
        private FontAwesome.Sharp.IconButton btn_logout;
        private MetroFramework.Controls.MetroLabel lbl_Usr;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private FontAwesome.Sharp.IconPictureBox pic_iconUsr;
        private MetroFramework.Controls.MetroPanel pnl_print;
        private System.Windows.Forms.Panel pnl_printAction;
        private System.Windows.Forms.Button btn_facturePrint;
        private System.Windows.Forms.Button btn_facturePrintHebdo;
        private System.Windows.Forms.Panel pnl_factureCommand;
        private System.Windows.Forms.Button btn_facturePrintMensuel;
        private System.Windows.Forms.Button btn_facturePrintAnnuel;
        private System.Windows.Forms.Label lbl_factureSearch;
        private System.Windows.Forms.TextBox txt_factureSearch;
        private System.Windows.Forms.DataGridView dtg_facture;
        private System.Windows.Forms.Panel pnl_searchAchatVente;
        private System.Windows.Forms.Label lbl_TopScorer;
        private System.Windows.Forms.Panel pnl_achat_vente;
        private System.Windows.Forms.Panel pnl_transacAchat;
        private System.Windows.Forms.Panel pnl_searchHome;
        private System.Windows.Forms.Label lbl_homeSearch;
        private System.Windows.Forms.TextBox txt_homeSearch;
        private System.Windows.Forms.DataGridView dtg_portfolio;
        private System.Windows.Forms.Panel pnl_searchPortfolio;
        private System.Windows.Forms.Label lbl_portFsearch;
        private System.Windows.Forms.TextBox txt_portFsearch;
        private MetroFramework.Controls.MetroTile title_Achat;
        private System.Windows.Forms.DataGridView dtg_transac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtg_facture_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtg_facture_Crypto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtg_facture_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtg_facture_date;
        private MetroFramework.Controls.MetroTile title_home;
        private MetroFramework.Controls.MetroTile title_portfolio;
        private System.Windows.Forms.PrintPreviewControl prnt_prev_facture;
        private MetroFramework.Controls.MetroTile title_facturation;
        private System.Windows.Forms.Button btn_portFvendre;
        private MetroFramework.Controls.MetroComboBox cbo_portFcrypoList;
        private System.Windows.Forms.TextBox txt_achatSearch;
        private System.Windows.Forms.NumericUpDown nud_achatSlTpVal;
        private System.Windows.Forms.NumericUpDown nud_achatQuant;
        private System.Windows.Forms.Button btn_achatValider;
        private System.Windows.Forms.GroupBox gpb_slTp;
        private System.Windows.Forms.CheckBox chk_achatSl;
        private System.Windows.Forms.CheckBox chk_achatTP;
        private System.Windows.Forms.Label lbl_achatQuant;
        private System.Windows.Forms.Label lbl_achatSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgHome_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgHome_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgHome_Achat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgHome_Vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgHome_Evol;
        private System.Windows.Forms.Label lbl_portFretourTransac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgPortfolio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgPortfolio_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgPortfolio_buyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgPortfolio_Gain;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgPortfolio_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgPortfolio_slTp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgTransac_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgTransac_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgTransac_Achat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgTransac_Vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dtgTransac_Evol;
        private System.Windows.Forms.PictureBox pct_logo;
    }
}