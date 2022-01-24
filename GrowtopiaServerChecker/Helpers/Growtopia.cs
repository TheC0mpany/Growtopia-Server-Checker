using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace GrowtopiaServerChecker
{
    class Growtopia
    {
        public static async Task Get(string firstOr2nd)
        {
            HttpClient client = new HttpClient();
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\info.txt";
            if (firstOr2nd == "growtopia1" || firstOr2nd == "growtopia2")
            {
                if (firstOr2nd == "growtopia1")
                {
                    var response = await client.PostAsync("http://growtopia1.com/growtopia/server_data.php", new FormUrlEncodedContent(new Dictionary<string, string> { { "TheC0mpany Dont Know", " How To Code" } }));
                    var info = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("From: 'http://growtopia1.com/growtopia/server_data.php':\n");
                    Console.WriteLine(info);
                    System.IO.File.WriteAllText(path, info);
                    Console.WriteLine("Saved at: " + path);
                }
                else if (firstOr2nd == "growtopia2") // U dont need POST u can use GET, but still it will work with POST
                {
                    var response = await client.PostAsync("http://growtopia2.com/growtopia/server_data.php", new FormUrlEncodedContent(new Dictionary<string, string> { { "TheC0mpany Dont Know", " How To Code" } }));
                    var info = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("From: 'growtopia2.com/growtopia/server_data.php':\n");
                    Console.WriteLine(info);
                    System.IO.File.WriteAllText(path, info);
                    Console.WriteLine("Saved at: " + path);
                }
            }
            else
            {
                Console.WriteLine("'" + firstOr2nd + "' is not valid argument.");
            }
        }
    }
}