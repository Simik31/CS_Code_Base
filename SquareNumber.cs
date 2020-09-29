using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    public class SquareNumber
    {
        public static long get(long n)
        {
            return Pow.Long(n, 2);
        }

        public static long reverse(long n)
        {
            return (long)Math.Sqrt(n);
        }
    }
}
