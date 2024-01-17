using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission__2 // create a new namespace
{
    // Tyler Sheffield Section 2
    internal class rollDice // create rollDice class
    {

        public int[] SimulateRolls(int numberOfRolls) // Simulate rolls Method
        {
            Random random = new Random();
            int[] results = new int[11]; // An array to store results for sums 2 to 12 (index 0 to 10)

            for (int iCount = 0; iCount < numberOfRolls; iCount++)
            {
                int dice1 = random.Next(1, 7); // get random numbers
                int dice2 = random.Next(1, 7);

                int sum = dice1 + dice2; // add the random roll numbers together

                if (sum >= 2 && sum <= 12)
                {
                    results[sum - 2]++; // Increment the counter for the sum in the array
                }
            }

            return results; // return results array
        }

    }
}
