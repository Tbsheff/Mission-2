using Mission__2;
using System;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?\n");

        int rolls = int.Parse(Console.ReadLine());

        rollDice simulation = new rollDice();

        Dictionary<int, int> output = simulation.SimulateRolls(rolls);

        Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = {rolls}.\r\n");
        foreach (var kvp in output)
        {
            Console.Write($" {kvp.Key}: ");
            float percent = (float)kvp.Value / rolls * 100;

            int roundedValue = (int)Math.Round(percent, MidpointRounding.AwayFromZero);

            for (int iCount = 0; iCount < roundedValue; iCount++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\r\n");
    }
}