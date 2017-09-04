using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmachine
{
    class AttChanceFinder
    {
        int[] d6 = { 1, 2, 3, 4, 5, 6 };
        public AttChanceFinder(int NumberOfDice)
        {

            for (int i = 1; i <= NumberOfDice + 2; i++)
            {
                foreach (int bi in d6)
                {

                }
            }
        }
    }
}
