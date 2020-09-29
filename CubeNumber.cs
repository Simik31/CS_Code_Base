using System;

namespace CodeBase
{
    public class CubeNumber
    {
        public static long get(long n)
        {
            return Pow.Long(n, 3);
        }

        public static long reverse(long n)
        {
            return (long)Math.Pow(n, 1.0 / 3);
        }
    }
}
