using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;




	
namespace Wex
{
    public class BTCResult
    {
        public long high { get; set; }
        public long low { get; set; }
        public long Last { get; set; }
        public long Buy { get; set; }
    }

    class Wex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Курс валюты с Wex");
            //  String Url = "https://wex.nz/api/3/ticker/btc_usd";

            WebRequest wrGETURL = WebRequest.Create("https://wex.nz/api/3/ticker/btc_usd");
            
           // wrGETURL = WebRequest.Create(Url);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
           // Console.WriteLine(objReader.ReadToEnd());

        string json = @"{
            'btc_usd':'btc_usd',
            'Low':'5000',
            }";

            BTCResult account = JsonConvert.DeserializeObject<BTCResult>(objReader.ReadToEnd());
            Console.WriteLine(account);


            // string sLine = "";
            // sLine = objReader.ReadLine();
            // Console.WriteLine(sLine);
          //  { "btc_usd":{ "high":8500,"low":8061.279,"avg":8280.6395,"vol":22359135.4628,"vol_cur":2719.18898,"last":8276.581,"buy":8290,"sell":8263.161,"updated":1511341515} }


            // Console.WriteLine("Введите первое число");
            //string S1 = Console.ReadLine();
            //int a = int.Parse(S1);

            //Console.WriteLine("Введите второе число");
            //string S2 = Console.ReadLine();
            //int b = int.Parse(S2);
            //int c = a + b;
            //Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + c.ToString());


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

       
    }
}