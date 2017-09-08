using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csdemo
{
    class DownloadAsyncDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading Syncronously");
            var result = Download();
            Console.WriteLine("In Main....");
           
            Console.WriteLine("Downloading Asyncronously");
            var resulttask = DownloadAsync();
            // main is busy displaying dots
            for(int i=1; i < 100; i ++)
            {
                // Thread.Sleep(100);
                Console.Write('.');
            }

            Console.WriteLine("\nDone");
            // Console.WriteLine(resulttask.Result);
            Console.WriteLine("The End");
        }

        static async Task<String> DownloadAsync()
        {
            var web = new WebClient();

            var result = await web.DownloadStringTaskAsync("http://www.srikanthtechnologies.com/rss.xml");
            Console.WriteLine("Received Result");
            //Thread.Sleep(10000);
            return result;
        }

        static String Download()
        {
            var web = new WebClient();
            Thread.Sleep(5000);
            var result = web.DownloadString("http://www.srikanthtechnologies.com/rss.xml");
            Console.WriteLine("Received Data");
            return result;
        }
    }
}
