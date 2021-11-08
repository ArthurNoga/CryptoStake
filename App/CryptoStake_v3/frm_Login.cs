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
            txt_username.Focus();
        }
         




        // Login  
        private void Btn_login_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            String user = "";
            if (txt_username.Text == "error" & txt_password.Text == "error")//TODO :query username +login +cryptage Login
            {
                MetroMessageBox.Show(this, "Username ou Password incorrect", "Problème lors de la Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txt_password.Text == "" || txt_username.Text == "error")
            {
                MetroMessageBox.Show(this, "Password ou login Vide", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            // TODO: verification du login avec la data base instanciation singleton user-> user=user.getInstance.getNom...
            else if (txt_username.Text == "ok") { isValid = true; user = " Arthur Noguera"; }
            if (isValid)
            {
               
                   
           
                MetroForm main = new Frm_main();
                main.Show();
                MetroMessageBox.Show(this, "Bienvenue sur CryptoStake " + user, "Connection Réussie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }

        }

        
        
        //inscription
        
        private void Btn_inscrip_Click(object sender, EventArgs e)
        {
            if(txt_Inscrip_nom.Text==""|| txt_Inscrip_Prenom.Text== "" || txt_Inscrip_username.Text=="" ||txt_inscrip_password.Text=="") {
                MetroMessageBox.Show(this, "veuillez remplir tout les champs", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (ContainsNumber(txt_Inscrip_nom.Text) || ContainsNumber(txt_Inscrip_Prenom.Text))
            { MetroMessageBox.Show(this, "Le prenom ou le nom contient un chiffre", "Un paramètre est faux", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (ContainsNumber(txt_Inscrip_Prenom.Text)) { txt_Inscrip_Prenom.Focus(); }
                if (ContainsNumber(txt_Inscrip_nom.Text)) { txt_Inscrip_nom.Focus(); }
            }

            else
            {
                //ecriture dans la database nouvel user
                MetroMessageBox.Show(this, "Merci de vous etre inscrit sur CryptoStake, Vous pouvez maintenant vous logger pour accéder à votre compte ", "Inscritpion Réussie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }



        private static bool ContainsNumber(String val)
        {
            String[] numberArray = { "1", "2", "3", "4", "5", "6", "7", "9", "0" };
            if (numberArray.Any(val.Contains)) { return true; }
            return false;
        }
    }
}
