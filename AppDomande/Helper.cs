using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Javax.Crypto.Spec;

namespace AppDomande
{
    class Helper
    {
        public static void Invia(string Domanda)
        {
            WebClient webClient = new WebClient();
            webClient.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");
                try
                {
                    var domandeProv = webClient.DownloadData("ftp://www.teatrotse.com/teatrotse.com/Visualizer/roboso.txt");

                var domande = Encoding.UTF8.GetString(domandeProv);
                    domande += Domanda + "/";
                    var newdomande = Encoding.UTF8.GetBytes(domande);
                    webClient.UploadData("ftp://www.teatrotse.com/teatrotse.com/Visualizer/roboso.txt", newdomande);
                }
                catch (Exception e)
                {
                    var domandaprima = Encoding.UTF8.GetBytes(Domanda);
                    webClient.UploadData("ftp://www.teatrotse.com/teatrotse.com/Visualizer/roboso.txt", domandaprima);
                }
            

        }
  

    }
}
