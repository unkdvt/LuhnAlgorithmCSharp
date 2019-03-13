using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            r: Console.Write("Enter Card Number or type Q or q to exit : ");
            string input = Console.ReadLine();
            if (input.ToUpper().Equals("Q"))
                Environment.Exit(0);
            bool x = Luhn.check(input);
            if (x)
                Console.WriteLine("Valid Card");
            else
                Console.WriteLine("Invalid Card");

            goto r;

        }


    }
}
