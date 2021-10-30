using CryptoStake_v3.Domaine;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Net;
using System.Web;


namespace CryptoStake_v3.Services
{
    class Crypto_API
    {

        private static string API_KEY = "67234b1f-75e4-41b2-b6cf-72023775cb41";
        private static int nbCryptos = 100;

        public static ArrayList GetCryptosFrmApi()
        {
            ArrayList cryptos = new ArrayList();



            String fJson = makeAPICall();
            JToken json = JObject.Parse(fJson);
            int cpt = 0;



            foreach (var e in json.SelectToken("data"))
            {
                String name = (String)json.SelectToken("data[" + cpt + "].name");
                String id = (String)json.SelectToken("data[" + cpt + "].symbol");
                String prix = (String)json.SelectToken("data[" + cpt + "].quote.CHF.price");
                String evolution = (String)json.SelectToken("data[" + cpt + "].quote.CHF.percent_change_24h");
                Crypto crypto = new Crypto(id, name, float.Parse(prix), float.Parse(evolution));
                cryptos.Add(crypto);
                cpt++;


            }


            return cryptos;
        }

        static string makeAPICall()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = nbCryptos + "";
            queryString["convert"] = "chf";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            return client.DownloadString(URL.ToString());
        }
    }
}




