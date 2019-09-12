/**
 * Christopher Boehm
 * Iterative Statement
 * 9/12/2019
 */

using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks the user for input 
            Console.WriteLine("Please enter an integer value between 1 and 100. ");
            try
            {
                //gets the users inputted value and parses to int
                string input = Console.ReadLine();
                int new_input = int.Parse(input);

                //if statement to make sure the grade is between 1 and 100
                if ((new_input >= 1) && (new_input <= 100))
                {
                    //for loop to print output
                    for (int i = 1; i < new_input + 1; i++)
                    {
                        //outputs and prints to screen
                        Console.WriteLine(" You have entered: " + new_input.ToString() + " This is the current integer value in loop: " + i.ToString());
                    }
              
                }
                else
                {
                    //lets the user know an incorrect value has been entered
                    Console.WriteLine("Please enter a integer value between 1 and 100! ");
                }
                //pauses the program
                Console.ReadLine();
            }
            
            catch
            {
                //incase of error let the user know
                Console.WriteLine("You have an error");
            }
        }
    }
}
