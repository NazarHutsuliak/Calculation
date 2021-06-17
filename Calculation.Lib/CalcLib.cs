using System;

namespace Calculation.Lib
{
    public static  class CalcLib
    {
        public static int  Addition(int x, int y)
        {
            return x + y;
        }
        public static int Substraction(int x, int y)
        {
            return x - y;
        }
        public static double Division(double x, double y )
        {
            if (y == 0)
                throw new ArgumentException("y can not be null");
            return x / y;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}
