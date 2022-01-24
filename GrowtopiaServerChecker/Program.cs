using System;
using System.Threading.Tasks;

namespace GrowtopiaServerChecker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Growtopia Server Checker that get from growtopia1 and growtopia2 information.\nMade by TheC0mpany\nSources: github.com/TheC0mpany/Growtopia-Server-Checker\nType: 'growtopia1' or 'growtopia2'.");
            while (true)
            { 
            string option = Console.ReadLine();
            Task task = Growtopia.Get(option);
            }
        }
    }
}