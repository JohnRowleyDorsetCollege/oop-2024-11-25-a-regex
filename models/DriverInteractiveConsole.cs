using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oop_2024_11_25_a_regex.models
{
    public static class DriverInteractiveConsole
    {
        public static void Run()
        {
            bool continueRunning = true;
            while (continueRunning)
            {

                Console.WriteLine("1.\t Say Hello");
                Console.WriteLine("2.\t Display current date and time");
                Console.WriteLine("3.\t Validate EirCode");
                Console.WriteLine("4.\t Exit");
                Console.WriteLine("\n\nEnter your choice (1-4): ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        SayHello();
                        break;
                    case "2":
                        ShowDateTime();
                        break;
                    case "3": 
                        ValidateEirCode();  
                        break;
                    case "4": continueRunning = false; break;
                    default: Console.WriteLine("Finished"); break;
                }

                if (continueRunning)
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
        }

        public static void SayHello()
        {
            Console.WriteLine("\nHello");
        }
        public static void ShowDateTime()
        {
            Console.WriteLine($"\nThe current date and time is {DateTime.Now}");
        }
        public static void ValidateEirCode()
        {
            Console.WriteLine($"\nEnter an EirCode to Validate:");
           
            string userInput = Console.ReadLine();

            // Regex pattern to validate eircode address
            string pattern = @"^[A-Z]{1}\d{2} [A-Z]{1}[A-Z\d]{3}$";


            if (Regex.IsMatch(userInput,pattern))
            {
                Console.WriteLine("The input is a valid eircode address.");
            }
            else
            {
                Console.WriteLine("The input is not a valid eircode address.");
            }
        }
    }
}
