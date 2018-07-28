using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandomNumbers
{
    class Program
    {
        static void Main()
        {
            // Random Numbers
            // Define Data Types for Random Numbers
            Random myRnd = new Random();

            for (int i=1; i<=10; i++)
            {
                // Print Random Number for each Item Number
                Console.WriteLine($"Item number {i} has the random number of {myRnd.Next(1, 100)}");
            }
        }
    }
}
