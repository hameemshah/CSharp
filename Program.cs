using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("{0:f3}",Math.PI);
            // Console.WriteLine("{0:d4}", 2);
            // Console.WriteLine("{0:c}", 10);
            // Console.WriteLine("{0:n3}", 2383928);
            // Console.WriteLine("{0}",int.MaxValue);
            // Console.WriteLine("{0}",int.MinValue);
            // Console.WriteLine("{0}",Double.MaxValue);
            //Console.ReadLine();
            bool boolFromStr = bool.Parse("true");
            Console.WriteLine(boolFromStr);
        }
    }
}