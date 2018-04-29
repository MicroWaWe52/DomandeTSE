using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsAppTheatherAsk
{
    class Helper
    {
        public static string[] CallFTP()
        {
            WebClient webClient = new WebClient();
            webClient.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");
            byte[] fileData = webClient.DownloadData("ftp://www.teatrotse.com/teatrotse.com/Visualizer/roboso.txt");
            var DomandeList = default(string[]);
            try
            {
                var domande = Encoding.UTF8.GetString(fileData);
                DomandeList = StringSplitter(domande);
                Array.Resize(ref DomandeList,DomandeList.Length-1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }finally { webClient.Dispose(); }
            return DomandeList;
        }

        public static string[] StringSplitter(string input)
        {
            return input.Split('/');
        }

        public static void Rifiuta(string Input)
        {
            WebClient webClient = new WebClient();
            webClient.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");
            byte[] bytes=Encoding.UTF8.GetBytes(Input);
            webClient.UploadData("ftp://www.teatrotse.com/teatrotse.com/Visualizer/roboso.txt", bytes);
            webClient.Dispose();

        }

        public static void Accetta(string Input, string domInput)
        {
            WebClient webClient = new WebClient();
            webClient.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");
            var bytes= Encoding.UTF8.GetBytes(Input);
            webClient.UploadData("ftp://www.teatrotse.com/teatrotse.com/Visualizer/text.txt", bytes);
            webClient.Dispose();
            Rifiuta(domInput);
        }

    }
}
