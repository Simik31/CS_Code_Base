using System;
using System.Numerics;

namespace CodeBase
{
    public class Palindromic
    {
        public static bool check(String num)
        {
            for (int i = 0; i < num.Length; i++) if (!num.Substring(i, 1).Equals(num.Substring(num.Length - i - 1, 1))) return false;
            return true;
        }

        public static bool check(int num)
        {
            return check(num.ToString());
        }

        public static bool check(long num)
        {
            return check(num.ToString());
        }

        public static bool check(BigInteger num)
        {
            return check(num.ToString());
        }
    }
}
