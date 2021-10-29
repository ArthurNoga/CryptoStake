
using JsonListManipulation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web;

class CSharpExample
{
    private static string API_KEY = "67234b1f-75e4-41b2-b6cf-72023775cb41";
    private static string json;

    public static void Main(string[] args)
    {
        try
        {
            String fJson = makeAPICall();
            JToken json = JObject.Parse(fJson);
            int cpt = 0;

            
       
           foreach (var e in json.SelectToken("data"))
            {
                String name = (String)json.SelectToken("data["+cpt+"].name");
                String id = (String)json.SelectToken("data[" + cpt + "].id");
                String prix = (String)json.SelectToken("data[" + cpt + "].quote.CHF.price");
                String evolution = (String)json.SelectToken("data[" + cpt + "].quote.CHF.percent_change_24h");

                Console.WriteLine(evolution+"%");
                cpt++;
             
                
            }

              
        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static string makeAPICall()
    {
        var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

        var queryString = HttpUtility.ParseQueryString(string.Empty);
        queryString["start"] = "1";
        queryString["limit"] = "100";
        queryString["convert"] = "chf";

        URL.Query = queryString.ToString();

        var client = new WebClient();
        client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
        client.Headers.Add("Accepts", "application/json");
        return client.DownloadString(URL.ToString());

    }
}