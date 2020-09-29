using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    public class InRange
    {
        public static bool Check(long check, long min, long max)
        {
            return min <= check && check <= max;
        }
    }
}
