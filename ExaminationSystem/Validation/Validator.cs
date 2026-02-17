using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Validation
{
    public static class Validator
    {
        //1. validate strings
        public static string GetValidString(string message, int min, int max)
        {

            while (true)
            {

                Console.WriteLine(message);
                Console.WriteLine();

                string input = Console.ReadLine();
                // null, whitesapce
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be null or whitespace. Please try again.");
                    continue;
                }

                // length 
                if (input.Length > max || input.Length < min)
                {
                    Console.WriteLine($"Input must be between {min} and {max}. Please try again.");
                    continue;
                }
                return input;

            }

        }

        //2. validate int   
        public static int GetValidInt(string message, int min, int max)
        {

            while (true)
            {

                Console.WriteLine(message);
                Console.WriteLine();

                string input = Console.ReadLine();
                // null, whitesapce
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be null or whitespace. Please try again.");
                    continue;
                }

                // tryparsing

                if (!int.TryParse(input, out int result))
                {
                    Console.WriteLine("Input must be a valid integer. Please try again.");
                    continue;
                }

                // length 
                if (result > max || result < min)
                {
                    Console.WriteLine($"Input must be between {min} and {max}. Please try again.");
                    continue;
                }
                return result;

            }
        }
    }
}
