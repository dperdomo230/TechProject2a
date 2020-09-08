/* 
    Author: Daniel Perdomo
    Date: 7 September 2020
    Comments: This C# console application code demonstrates the use of
              iterative statements after getting user input.
*/
 
using System;

namespace TechProject2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input 
            Console.Write("Enter an integer value between 1 and 25 to execute an iterative statement: ");

            /* 
                Use the try catch block to validate user input.
                If the user provides bad input, the catch block 
                will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather input from the user 
                string input = Console.ReadLine();
                // This varibale will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);

                /*
                    This conditinal if/else statement is used to test the values of user input. 
                    Iterative statement will execute depending on the value of user input.
                */
                // Execute a for loop if the value of user input is between 1 and 25.
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a for loop!");
                    Console.WriteLine("The for loop will iterate " + value_of_input.ToString() + " times.");

                    // Here is the for loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input + "." 
                        + "This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program 
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again ...");
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
        }// End of main
    } // End of class
}// End of namespace
