using System;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwapPartAPITest
{
    public class API
    {

        WebClient client = new WebClient();

        public async void GetConversion(double amount)
        {
            string apiString = await client.DownloadStringTaskAsync("http://api.currencylayer.com/live?access_key=770167921046a814f8fd5003086e6b6c&currencies=GBP");

            JObject jsonData = JObject.Parse(apiString);

            Debug.Print(jsonData.ToString());

            JObject result = (JObject)jsonData["quotes"];

            Debug.Print(result.ToString());

            //Currency.Conversion = result["quotes"].ToString();
            double toPass = Convert.ToDouble(result["USDGBP"]);
            Currency.Rate = toPass;


        }

     }



    
}