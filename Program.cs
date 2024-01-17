using Mission__2;
using System;
using System.Runtime.InteropServices;

internal class Program
{
    // Tyler Sheffield Section 2 Mission 2
    private static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?\n"); // Print Welcome message

        int rolls = int.Parse(Console.ReadLine()); // Get input from user, how many rolls

        rollDice simulation = new rollDice(); // create a new rollDice object

        int[] output = simulation.SimulateRolls(rolls); // create a dictionary of results by calling the simulate rolls method

        // Print results
        Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = {rolls}.\r\n");
        for (int iCount =0; iCount < output.Length; iCount ++)
        {
            Console.Write($" {iCount + 2}: ");
            float percent = (float)output[iCount] / rolls * 100; // get percentage of total rolls for each value

            int roundedValue = (int)Math.Round(percent, MidpointRounding.AwayFromZero); // round percentage

            for (int iCount2 = 0; iCount2 < roundedValue; iCount2++)
            {
                Console.Write("*"); // write 1 * for each percentage point
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\r\n"); // ending message
    }
}