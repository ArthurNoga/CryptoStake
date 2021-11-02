using CryptoStake_v3.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CryptoStake_v3
{
    public partial class Frm_Login : MetroForm



    {
        public Frm_Login()
        {
            InitializeComponent();



        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
         //TODO: charger database
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            if (txt_username.Text == "error"&txt_password.Text=="error")//TODO :query username +login +cryptage Login
            {
                MetroMessageBox.Show(this, "Username ou Password incorrect", "Problème lors de la Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
            if (txt_password.Text == "" || txt_username.Text == "error") {
                MetroMessageBox.Show(this, "Password ou login Vide", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_username.Text == "ok") { isValid = true; }
            if (isValid)
            {
                MetroForm main = new Frm_main();
                main.Show();
                this.Hide();
            }

        }

        private void Btn_inscrip_Click(object sender, EventArgs e)
        {
            if (ContainsNumber(txt_Inscrip_nom.Text) || ContainsNumber(txt_Inscrip_Prenom.Text)) { MetroMessageBox.Show(this, "Le prenom ou le nom contient un chiffre", "Un paramètre est faux", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }

            else {
                //ecriture dans la database nouvel user
                
                
                MetroMessageBox.Show(this, "Merci de vous etre inscrit sur CryptoStake", "Inscritpion Réussie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }



        private static bool ContainsNumber(String val)
        {
            String[] numberArray = { "1", "2", "3", "4", "5", "6", "7", "9", "0" };
            if (numberArray.Any(val.Contains)) { return true; }
            return false;
        }
    }
}
