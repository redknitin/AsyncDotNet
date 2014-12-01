using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTry1
{
    class Program
    {
        static async Task<bool> DoSomething()
        {
            await Task.Run(() => { System.Threading.Thread.Sleep(5000); Console.WriteLine("Hello"); });            
            return true;
        }

        static void Main(string[] args)
        {
            var d = DoSomething();
            Console.WriteLine("Done thing");
            d.Wait();
            Console.Read();
        }
    }
}
