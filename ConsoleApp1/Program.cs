using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sw = new Stopwatch();

            var a = new HttpClient();

            sw.Start();
            var result = await a.GetByteArrayAsync("https://speed.hetzner.de/100MB.bin");
            sw.Stop();

            Console.WriteLine($"Downloaded {result.Length} bytes in {sw.Elapsed.TotalSeconds} seconds");
            Console.ReadKey();
        }
    }
}
