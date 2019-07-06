using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("Please enter a number between 1 and 100 (Inclusive):");
            number = Convert.ToInt32(Console.ReadLine());

            divisibleByTwo(number); 
            upperFiftyPercentile(number);   
            favoriteNumber(number);

            Console.ReadKey();
        }

        static void divisibleByTwo(int number)
        {
            if ((number % 2) == 0)
            {
                Console.WriteLine($"The number {number} is divisible by two!");
            }
            else
            {
                Console.WriteLine($"The number {number} is NOT divisible by two!");
            }
            Console.WriteLine();
        }

        static void upperFiftyPercentile(int number)
        {
            if (number > 50)
            {
                Console.WriteLine($"The number {number} is in the UPPER 50% of the number range!");
            }
            else
            {
                Console.WriteLine($"The number {number} is in the LOWER 50% of the number range!");
            }
            Console.WriteLine();
        }

        static void favoriteNumber(int number)
        {
            if (number == 3)
            {
                Console.WriteLine($"Hey, No Way! Number {number} is my creators favorite number!");
            }
        }
    }
}
