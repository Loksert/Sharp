using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text.RegularExpressions;

namespace C_Sharp_Learn
{


    class Program
    {
        public static bool sumTwoSmallestNumbers(string f)
        {
            string result = new string(f.Where(t => char.IsDigit(t)).ToArray());
            if (result == f)
            {
                if (f.Length == 6 || f.Length == 4)
                {
                    return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            var a = sumTwoSmallestNumbers("345566");
            Console.WriteLine(a);
        }
    }
}
