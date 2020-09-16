/*
    Author: Catherine Santos
    Date: 9/15/2020
    Comments: This C# Console application code demonstrates the use of
              iterative statements after getting input from users. 
*/


using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for input
            Console.Write("Enter an Integer value between 1 and 25 to execute an iterative statement. ");
            /*
               The try catch block will validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed. 
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // The variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                /*
                 *  This conditional IF/ELSE statement is used to test the values of user input.
                 */
                // If the value of user inout is between 1 and 25, execute a while loop 
                if ((value_of_input >= 1) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a While Loop");
                    Console.WriteLine("The While Loop will iterate " + value_of_input.ToString() + " times.");
                    // While Loop is written here
                    while (value_of_input > 0)
                    {
                        Console.WriteLine("You have entered " + input.ToString() + ". This is the current integer value in the loop: " + value_of_input.ToString());
                        value_of_input--;
                    }
                    Console.WriteLine("Press any key to exit the program ... ");
                    Console.ReadKey(true);
                }
                // If the user does not enter a value between 1 and 25, display a message
                else
                { 
                    Console.WriteLine("Please enter an integer betweeen 1 and 25 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
} // End of class
