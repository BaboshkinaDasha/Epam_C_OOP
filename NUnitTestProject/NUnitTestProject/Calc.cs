using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject
{
    public static class Calc
    {
        static public int Plus(int x, int y)
        {
            return x + y;
        }
        static public int Minus(int x, int y)
        {
            return x - y;
        }
        static public int Mult(int x, int y)
        {
            return x * y;
        }
        static public int Div(int x, int y)
        {
            if (y == 0)
                return 0;
            return x / y;
        }
    }
}
