using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oop_2024_11_25_a_regex.models
{
    public static class DriverRegex
    {
        public static void Run()
        {
            EirCode();
            TheoryChallenge();
            SimpleTextWithNumber();
            SimpleNumber();
            SimpleString();
        }

        public static void SimpleString()
        {
            // ^ => start of string
            // $ => up until end of string
            // [??] => accepted tokens
            // {x} => number of tokens expected
            string pattern = @"^[A-Z]{2}$";
            string pattern2 = @"^[a-zA-Z]{2}$";

            string[] testStrings = { "AB", "ab", "Cd", "DC" };
            ValidatePattern(pattern,  testStrings);
            ValidatePattern(pattern2,  testStrings);
        }

        private static void ValidatePattern(string pattern, string[] testStrings)
        {
            foreach (string testString in testStrings)
            {

                if (Regex.IsMatch(testString, pattern))
                {

                    Console.WriteLine($"\n{testString} is validated");
                }
                else
                {
                    Console.WriteLine($"\n\t{testString} is NOT validated against {pattern}");
                }
              
            }
        }

        public static void SimpleNumber()
        {
            // ^ => start of string
            // $ => up until end of string
            // \d => expected token is a digit
            // {x} => number of tokens/digits expected 
            string pattern = @"^\d{4}$";


            string[] testStrings = { "1234", "234", "45", "4567" };
            ValidatePattern(pattern, testStrings);
        }
        public static void SimpleTextWithNumber()
        {
            // ^ => start of string
            // $ => up until end of string
            // [a-zA-Z] => accepted tokens
            // \d => expected token is a digit
            // {x} => number of tokens/digits expected 
            string pattern = @"^[a-zA-Z]{2}\d{4}$";


            string[] testStrings = { "AB1234", "CD234", "EF45", "GH4567", "KL45x7" };
            ValidatePattern(pattern, testStrings);


        }
        public static void TheoryChallenge()
        {
            string[] testStrings = { "AB-12-34-abcd" , "XY-67-01-xxxy", "invalid-567-n"};
            string pattern = @"^[A-Z]{2}-\d{2}-\d{2}-[a-z]{4}$";
            ValidatePattern(pattern, testStrings);
        }


        public static void EirCode()
        {
            string[] testStrings = { "D18 H5TV", "D18 KH67", "K56 DK25", "K56DK25", "K67 5K25" };
            string pattern = @"^[A-Z]{1}\d{2} [A-Z]{1}[A-Z\d]{3}$";
            ValidatePattern(pattern, testStrings);
        }
    }
}
