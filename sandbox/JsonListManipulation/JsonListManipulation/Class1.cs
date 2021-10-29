using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonListManipulation
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class Crypto
    {
        public class Coin
        {
            public int id { get; set; }
            public string name { get; set; }
           
        }

        public class Data
        {
            public string id { get; set; }
            public string project_name { get; set; }
            public string description { get; set; }
            public string status { get; set; }
            public Coin coin { get; set; }
            public DateTime start_date { get; set; }
            public DateTime end_date { get; set; }
            public long total_prize { get; set; }
            public int winner_count { get; set; }
        }

        public class Status
        {
            public DateTime timestamp { get; set; }
            public int error_code { get; set; }
            public string error_message { get; set; }
            public int elapsed { get; set; }
            public int credit_count { get; set; }
        }

        public class Root
        {
            public Data data { get; set; }
            public Status status { get; set; }
        }


    }
}