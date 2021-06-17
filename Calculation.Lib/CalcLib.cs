using System;

namespace Calculation.Lib
{
    public class CalcLib
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Dif(int x, int y)
        {
            return x - y;
        }
        public int Div(int x, int y)
        {
            if (y == 0)
                throw new ArgumentException("y can not be null");
            return x / y;
        }
        public int Mult(int x, int y)
        {
            return x * y;
        }
    }
}
