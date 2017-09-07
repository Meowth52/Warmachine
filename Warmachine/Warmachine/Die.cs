using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmachine
{
    public class Die
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
            CurrentSide++;
            if (CurrentSide > 6)
            {
                CurrentSide = 1;
                return true;
            }
            else
                return false;            
        }
    }
}
