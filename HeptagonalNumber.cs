using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    public class HeptagonalNumber
    {
        public static long get(long n)
        {
            return n * (5 * n - 3) / 2;
        }

        public static long reverse(long n)
        {
            long y = 1;
            while (get(y) != n) y++;
            return y;
        }
    }
}
