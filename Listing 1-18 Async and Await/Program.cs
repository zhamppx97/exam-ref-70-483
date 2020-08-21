﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Listing_1_18_Async_and_Await
{
    class Program
    {
        public static void Main()
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent()
        {
            using HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("https://www.microsoft.com");
            return result;
        }
    }
}
