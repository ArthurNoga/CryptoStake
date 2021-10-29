using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace sandboxAPi
{
    class JDBC1
    {

        private JDBC1() { }

        OracleConnection con = new OracleConnection(ConnectionString);
        private static String ConnectionString = "USER ID=SYSTEM;;Password=AZertyui21!;Data Source= localhost:1521 / XE; PERSIST SECURITY INFO = True";
        private static JDBC1 _instance;

        public static JDBC1 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new JDBC1();
            }
            return _instance;
        }


        public void testConnection()
        {
            //using connection string attributes to connect to Oracle Database

            con.Open();
            Console.WriteLine("Connected to Oracle" + con.ServerVersion);
            // Close and Dispose OracleConnection object
            con.Close();

            Console.WriteLine("Disconnected");
        }

        public void fetch_pers()
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
                        String prenom = dataReader.GetString(prenomInbdex);
                        Console.WriteLine(nid + " " + name + " " + prenom);
                    }
                }
            }
            con.Close();

        }


        public void insertUser(String p_nom, String p_prenom, String p_username, String p_password)
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
        public void inserCrypto(String p_nom, String p_prenom, String p_username, String p_password)
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
    }
}
