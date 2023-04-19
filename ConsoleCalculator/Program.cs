using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 2)
            {
                int arg1 = int.Parse(args[0]);
                int arg2 = int.Parse(args[1]);
                string oper = args[2];
                int rez = 0;
                switch (oper)
                {
                    case "+": rez = arg1 + arg2; break;
                    case "-": rez = arg1 - arg2; break;
                    case "*": rez = arg1 * arg2; break;
                    case "/": rez = arg1 / arg2; break;
                }
                Console.WriteLine($"{arg1}{oper}{arg2} = {rez}");
            }
            Console.ReadKey();

        }
    }
}
