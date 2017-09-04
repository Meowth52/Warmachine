using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmachine
{
    class Die
    {
        int CurrentSide;
        public Die()
        {
            CurrentSide = 1;
        }
        public int getCurrentSide()
        {
            return CurrentSide;
        }
        public bool isLastSide()
        {
            if (CurrentSide >= 6)
            {
                CurrentSide = 1;
                return true;
            }
            else
            {
                CurrentSide++;
                return false;
            }
            
        }
    }
}
