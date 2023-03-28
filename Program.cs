using System;
using System.Net.Http;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
namespace Project
{
    class MainPrpject
    {
        public int threadCount{get;set;}
        public static async Task SentHTTPRequest(int threadCount)
        {
            Task[] tasksThread = new Task[threadCount];
            for(int i = 0;i<threadCount;i++)
            {
                tasksThread[i]= Task.Run(()=>{
                    using(HttpClient client = new HttpClient())
                    {
                        HttpRequestMessage request = new HttpRequestMessage()
                        {
                            Headers ={

                            }
                        };
                    }
                });
                await Task.WhenAll(tasksThread);
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
