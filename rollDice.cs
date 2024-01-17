using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission__2
{
    internal class rollDice
    {
        public Dictionary<int, int> SimulateRolls(int numberOfRolls)
        {
            Random random = new Random();
            Dictionary<int, int> results = new Dictionary<int, int>();

            for (int iCount = 2; iCount < 13; iCount++)
            {
                results[iCount] = 0;
            }

            for (int i = 0; i < numberOfRolls; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int sum = dice1 + dice2;

                if (results.ContainsKey(sum))
                {
                    results[sum]++;
                }
                else
                {
                    results[sum] = 1;
                }
            }

            return results;
        }
    }
}
