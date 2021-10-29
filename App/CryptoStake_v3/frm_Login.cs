using CryptoStake_v3.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CryptoStake_v3
{
    public partial class frm_Login : MetroForm



    {
        public frm_Login()
        {
            InitializeComponent();

            JDBC database = JDBC.GetInstance();
            database.InsertCryptos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            if (txt_username.Text == "error")
            {
                MetroMessageBox.Show(this, "Username ou Password incorrect", "Problème lors de la Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_username.Text == "ok") { isValid = true; }
            if (isValid)
            {
                MetroForm main = new frm_main();
                main.Show();
                this.Hide();
            }

        }

        private void btn_inscrip_Click(object sender, EventArgs e)
        {
            if (ContainsNumber(txt_Inscrip_nom.Text) || ContainsNumber(txt_Inscrip_Prenom.Text)) { MetroMessageBox.Show(this, "Le prenom ou le nom contient un chiffre", "Un paramètre est faux", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }

            else { MetroMessageBox.Show(this, "Merci de vous etre inscrit sur CryptoStake", "Inscritpion Réussie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }



        private static bool ContainsNumber(String val)
        {
            String[] numberArray = { "1", "2", "3", "4", "5", "6", "7", "9", "0" };
            if (numberArray.Any(val.Contains)) { return true; }
            return false;
        }
    }
}
