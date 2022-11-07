using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine.Text;
using CommandLine;

namespace Konsoliohjelma_01_Bonus
{
    public class Program
    {
        public class Options
        {
            [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
            public bool Verbose { get; set; }
            [Option('u', "URL", Required = false, HelpText = "Set output to url.")]
            public string URL { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       if (o.Verbose)
                       {
                           Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
                           Console.WriteLine("App is in Verbose mode!");
                       }
                       else if (!string.IsNullOrEmpty(o.URL))
                       {
                           Console.WriteLine($"URL output enabled. Current Arguments: -u {o.URL}");
                           Console.WriteLine("App is in URL mode!");
                       }
                       else
                       {
                           Console.WriteLine($"Current Arguments: -v {o.Verbose} & -u {o.URL}");
                           Console.WriteLine("Give parameters in -v for verboses or -u for urls");
                       }
                   });
        }
    }
}