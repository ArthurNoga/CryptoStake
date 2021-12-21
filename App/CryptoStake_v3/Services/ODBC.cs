using CryptoStake_v3.Domaine;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Data;

namespace CryptoStake_v3.Services
{
    class ODBC
    {


        private ODBC()
        {

        }

        OracleConnection con = new OracleConnection(ConnectionString);

        private static String admin = "USER ID=SYSTEM;;Password=AZertyui21!;Data Source= localhost:1521 / XE; PERSIST SECURITY INFO = True";
         
        public OracleConnection getConnection() { return this.con; }

        public static String ConnectionString { get; set; } = admin;

        private static ODBC _instance;

        public static ODBC GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ODBC();
            }
            return _instance;
        }

        

        public void TestConnection()
        {
            //using connection string attributes to connect to Oracle Database

            con.Open();
            Console.WriteLine("Connected to Oracle" + con.ServerVersion);
            // Close and Dispose OracleConnection object
            con.Close();

            Console.WriteLine("Disconnected");
        }

        public void Fetch_pers()
        {
            String SQL = " Select * from Pers";
            OracleCommand req = new OracleCommand();
            req.Connection = con;
            req.CommandText = SQL;

            con.Open();
            using (System.Data.Common.DbDataReader dataReader = req.ExecuteReader())
            {
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        int id = dataReader.GetOrdinal("pers_id");
                        String nid = dataReader.GetString(id);
                        int nameInbdex = dataReader.GetOrdinal("pers_nom");
                        String name = dataReader.GetString(nameInbdex);
                        int prenomInbdex = dataReader.GetOrdinal("pers_prenom");

                    }
                }
            }
            con.Close();

        }


        public void InsertUser(String p_nom, String p_prenom, String p_username, String p_password)
        {

            String sql = "pkg_CryptoStake_RestUser.ajoutUtilisateur";
            OracleCommand req = new OracleCommand(sql, con);
            req.CommandType = CommandType.StoredProcedure;
            req.Parameters.Add("pers_nom", OracleDbType.Varchar2).Value = p_nom;
            req.Parameters.Add("pers_prenom", OracleDbType.Varchar2).Value = p_prenom;
            req.Parameters.Add("pers_userName", OracleDbType.Varchar2).Value = p_username;
            req.Parameters.Add("pers_password", OracleDbType.Varchar2).Value = p_password;
            con.Open();
            req.ExecuteNonQuery();
            con.Close();

        }


        public void InsertALLCryptosToDB()
        {

            ArrayList cryptos = Crypto_API.GetCryptosFrmApi();

            foreach (Crypto crypto in cryptos)
            {
                InsertCryptoToDB(crypto);
            }

        }
        public void InsertCryptoToDB(Crypto crypto)
        {
            String sql = "Cryptostake_data.pkg_crypto.upd_add_crypto";
            OracleCommand req = new OracleCommand(sql, con);
            req.CommandType = CommandType.StoredProcedure;
            req.Parameters.Add("CRYPT_ID", OracleDbType.Varchar2).Value = crypto.id;
            req.Parameters.Add("CRYPT_NOM", OracleDbType.Varchar2).Value = crypto.nom;
            req.Parameters.Add("CRYPT_ACHAT", OracleDbType.Double).Value = crypto.prixAch;
            req.Parameters.Add("CRYPT_VENTE", OracleDbType.Double).Value = crypto.prixVen;
            req.Parameters.Add("CRYPT_EVOL", OracleDbType.Double).Value = crypto.evol;
            con.Open();
                req.ExecuteNonQuery();
            con.Close();
        }

    }
}

