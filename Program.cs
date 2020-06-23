using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Calculating;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc.UserOut();

            Console.WriteLine("If you would like to restart the calculator, type \"y\". If you would like to end the calculator type \"n\" ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Clear();
                Console.Beep();
            }
            else if (Console.ReadLine().ToLower() == "n")
            {
                Environment.Exit(0);
            }
        }
    }
}
