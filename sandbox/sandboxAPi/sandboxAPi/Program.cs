using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Web;

namespace sandboxAPi
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject json = JObject.Parse(makeAPICall());

            String id = (String)json.SelectToken("data[0].symbol");
            String nom = (String)json.SelectToken("data[0].name");
            String prix = (String)json.SelectToken("data[0].quote.CHF.price");
            Console.WriteLine(id + " " + nom + " " + prix);
        }
        static string makeAPICall()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");
            const string API_KEY = "67234b1f-75e4-41b2-b6cf-72023775cb41";

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "1";
            queryString["convert"] = "chf";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string json = client.DownloadString(URL.ToString());
            return json;
        }

    } 
}
