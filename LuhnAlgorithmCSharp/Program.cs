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
            bool x = check(input);
            if (x)
                Console.WriteLine("Valid Card");
            else
                Console.WriteLine("Invalid Card");

            goto r;

        }

        /// <summary>
        /// Luhn Algorithm C#
        /// </summary>
        /// <param name="ccNumber"></param>
        /// <returns></returns>
        public static bool check(string ccNumber)
        {
            int sum = 0;
            bool alternate = false;
            for (int i = ccNumber.Length - 1; i >= 0; i--)
            {
                char[] nx = ccNumber.ToArray();
                int n = int.Parse(nx[i].ToString());

                if (alternate)
                {
                    n *= 2;

                    if (n > 9)
                    {
                        n = (n % 10) + 1;
                    }
                }
                sum += n;
                alternate = !alternate;
            }
            return (sum % 10 == 0);
        }
    }
}
