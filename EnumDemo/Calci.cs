using System;

namespace EnumDemo
{
    public static class Calc
    {
        // extension method syntax
        // first parameter should be the name of class, for which we want to add method
        public static int Multiply(this Calculation c1, int a, int b)
        {
            return a * b;
        }
    }
}
