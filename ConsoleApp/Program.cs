using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient httpclient = new HttpClient();

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.bing.com");

            HttpResponseMessage responseMessage = await httpclient.SendAsync(
                requestMessage,
                HttpCompletionOption.ResponseHeadersRead);

            Console.WriteLine("Is null" + responseMessage.RequestMessage == null);
        }
    }
}
