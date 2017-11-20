using System;
using System.Net;
using System.IO;

	
namespace Wex
{
    class Wex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Курс валюты с Wex");
            String Url = "https://wex.nz/api/3/btc_usd";
            
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(Url);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            sLine = objReader.ReadLine();
            Console.WriteLine(sLine);



            //Console.WriteLine("Введите первое число");
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