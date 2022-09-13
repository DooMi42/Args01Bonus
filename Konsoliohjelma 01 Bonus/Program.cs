using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsoliohjelma_01_Bonus
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("args is null");
            }
            else
            {
                Console.Write("args length is ");
                Console.WriteLine(args.Length);
                for (int i = 0; i < args.Length; i++)
                {
                    string argument = args[i];
                    Console.Write("args index ");
                    Console.Write(i);
                    Console.Write(" is [");
                    Console.Write(argument);
                    Console.WriteLine("]");
                }
            }

            Console.WriteLine("\nEnter Something to end the program");
            Console.ReadLine();
        }
    }
}