using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Konsoliohjelma_01_Bonus
{
    public class Program
    {
        static void Main(string[] args)
        {
            var switchMappings = new Dictionary<string, string>()
            {
                { "--verbose", "key1" },
                { "--test", "key2" },
                { "--url=www.google.com", "key3" },
            };

            var builder = new ConfigurationBuilder().AddCommandLine(args);
            var config = builder.Build();

            Console.WriteLine($"1: '{config["Key1"]}'");
            Console.WriteLine($"2: '{config["Key2"]}'");
            Console.WriteLine($"3: '{config["Key3"]}'");

            Console.WriteLine("\nEnter Something to end the program");
            Console.ReadLine();
        }
    }
}