using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Asynchronous_Programming
{
    public class Program
    {
        //Wherever we have blocking opperations like accessing files, databases, calling webservices, accessing calender, ect.
        //static void Main(string[] args)
        //{
        //}
        
        //This is how we download a file synchronic 
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
                streamWriter.Write(html);
            }
        }

        //This is how we do it asynchronically.
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
               await streamWriter.WriteAsync(html);
            }
        }

        //Not async
        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        //Async - because we return something we use generic task <> instead of just task which is used for void methods.
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
