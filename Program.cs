using System;

namespace FlowControl2
{
    class Program
    {
        /* Author: Jonathan Karcher
         * Purpose: To take two numbers form the user and display them if one or the other but not both of them are greater than 10
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            double var1 = 100;
            double var2 = 100;
            string input = "";
            do
            {
                // Give the user instruction
                Console.WriteLine("Please enter two numbers");
                input = Console.ReadLine();
                // If they didnt enter a number
                while (!Double.TryParse(input, out var1))
                {
                    // Ask the user for a new number
                    Console.WriteLine("This was not a number\nPlease enter a new number");
                    input = Console.ReadLine();
                }
                input = Console.ReadLine();
                // If they didnt enter a number
                while (!Double.TryParse(input, out var2))
                {
                    // Ask the user for a new number
                    Console.WriteLine("This was not a number\nPlease enter a new number");
                    input = Console.ReadLine();
                }
            }
            while ((var1 > 10) && (var2 > 10));
            // display the two numbers
            Console.WriteLine("Your two numbers are " + var1 + " and " + var2);
        }
    }
}
