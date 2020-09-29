using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CodeBase
{
    public class Factorial
    {
        public static BigInteger Biginteger(long n)
        {
            BigInteger ret = BigInteger.One;
            while (n > 0) ret = BigInteger.Multiply(ret, n--);
            return ret;
        }

        public static String String(long n)
        {
            if (n == 0) return "1";
            return Biginteger(n).ToString();
        }

        public static int Integer(int n)
        {
            int f = 1;
            while (n > 0) f *= n--;
            return f;
        }

        public static long Long(long n)
        {
            long f = 1;
            while (n > 0) f *= n--;
            return f;
        }
    }
}
