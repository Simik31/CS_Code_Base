﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    public class PentagonalNumber
    {
        public static long get(long n)
        {
            return n * (3 * n - 1) / 2;
        }

        public static long reverse(long n)
        {
            long y = 1;
            while (get(y) != n) y++;
            return y;
        }
    }
}
