using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission__2 // create a new namespace
{
    internal class rollDice // create rollDice class
    {
        public Dictionary<int, int> SimulateRolls(int numberOfRolls) // SimulateRolls method
        {
            Random random = new Random(); // new random object
            Dictionary<int, int> results = new Dictionary<int, int>(); // new dictionary object

            for (int iCount = 2; iCount < 13; iCount++)
            {
                results[iCount] = 0; // initialize the results dictionary
            }

            for (int i = 0; i < numberOfRolls; i++)
            {
                int dice1 = random.Next(1, 7); // get random numbers
                int dice2 = random.Next(1, 7);

                int sum = dice1 + dice2; // add the random roll numbers together

                if (results.ContainsKey(sum))
                {
                    results[sum]++; // increment the counter for the sum
                }
                else
                {
                    results[sum] = 1;
                }
            }

            return results; // return results dictionary
        }
    }
}
