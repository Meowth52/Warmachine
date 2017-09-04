using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmachine
{
    class Scmenum
    {
        public double Result;
        public string ResultString;
        public Scmenum(double result, int att, int pow, int extra)
        {
            Result = result;
            ResultString = result.ToString() + " from att:" + att.ToString() + ", pow:" + pow.ToString() + " and " + extra.ToString() + " extra attacks";
        }
    }
}
