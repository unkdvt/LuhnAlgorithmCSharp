using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithmCSharp
{
    public static class Luhn
    {
        /// <summary>
        /// Luhn Algorithm C#
        /// This class is created on 13 March 2019, at 17:17 (UTC).
        /// by Lakmal http://github.com/l4km47
        /// </summary>
        /// <param name="ccNumber">Credit/Debit/etc card number</param>
        /// <returns>bool</returns>
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
