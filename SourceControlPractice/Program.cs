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

            Console.ReadKey();
        }
    }
}
