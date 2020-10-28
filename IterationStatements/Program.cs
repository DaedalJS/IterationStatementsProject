using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0 - DONE
            int num = 0;

            // Create a do-while loop - DONE
            do
            {
                // Increment your variable by 1 - DONE
                num++;
                // Then add your variable to "numbers" - DONE
                numbers.Add(num);
            }
            // While your variable is less than 100 - DONE
            while (num < 100);


            // Create a while loop - DONE
            // While your variable is less than 200 - DONE
            while (num < 200)
            {
                // Increment your variable by 1 - DONE
                num++;
                // Then add your variable to "numbers" - DONE
                numbers.Add(num);
            }

                Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (var listednum in numbers)
            {

                // Write your variable to the console - DONE

                Console.WriteLine(listednum);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199 - DONE
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count) - DONE
            // and as long as i is greater than or equal to 0 - DONE
            // Decrement i by 1  - DONE
            for (int i = 199; i <= numbers.Count && i >=0; i--)
            {
                // Write to the console "numbers" at index i - DONE
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
