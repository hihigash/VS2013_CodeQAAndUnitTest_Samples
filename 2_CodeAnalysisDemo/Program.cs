using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeAnalysisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = args[0];
            char c = GetFirstChar(s, s.Length);

            // Fixed code
            //char c = GetFirstChar(s);

            Console.WriteLine(c);
        }

        private static char GetFirstChar(string s, int max)
        {
            if (s == "")
            {
                throw new ArgumentException("argument empty", "s");
            }

            return s[0];
        }

        // Fixed code
        //private static char GetFirstChar(string s)
        //{
        //    if (string.IsNullOrEmpty(s))
        //    {
        //        throw new ArgumentException("argument empty", "s");
        //    }

        //    return s[0];
        //}
    }
}
