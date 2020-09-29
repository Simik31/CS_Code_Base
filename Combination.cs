using System.Numerics;

namespace CodeBase
{
    public class Combination
    {
        public static BigInteger Biginteger(long n, long r)
        {
            return BigInteger.Divide(Factorial.Biginteger(n), BigInteger.Multiply(Factorial.Biginteger(r), Factorial.Biginteger(n - r)));
        }
    }
}
