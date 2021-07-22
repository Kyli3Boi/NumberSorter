using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number sorter");
            Console.WriteLine();
            Console.WriteLine("Enter 5 seperate numbers below");

            var numberCounter = 5;
            string userInput;
            var numbers = new List<string>();

            while (numberCounter > 0)
            {
                Console.Write("({0}) remaining: ", numberCounter);

                userInput = (Console.ReadLine());
                   
                if (!numbers.Contains(userInput))
                {
                    numbers.Add(userInput);

                    numberCounter--;
                }
                else
                {
                    Console.WriteLine("You already inserted that number");
                    continue;
                }
            }

            numbers.Sort();
            string sorted = string.Join(",", numbers);
            
            Console.WriteLine("Your numbers are sorted: {0}", sorted);

            Console.ReadKey();
        }
    }
}
