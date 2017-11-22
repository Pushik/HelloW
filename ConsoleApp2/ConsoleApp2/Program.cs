using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;




	
namespace Wex
{
    public class BTCResult
    {
        public long High { get; set; }
        public float Low { get; set; }
      //  public long Last { get; set; }
      //  public long Buy { get; set; }
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
            Console.WriteLine(objReader.ReadToEnd());

        string json = @"{
            'High coorse':'High',
            'Low coorse':'Low',

        }";
            BTCResult account = JsonConvert.DeserializeObject<BTCResult>(json);
            double high = account.High;
            float low = account.Low;
            Console.WriteLine(high);
            Console.WriteLine(low);


            // string sLine = "";
            // sLine = objReader.ReadLine();
            // Console.WriteLine(sLine);



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