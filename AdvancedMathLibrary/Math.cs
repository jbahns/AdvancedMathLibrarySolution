using System;

namespace AdvancedMathLibrary
{
    public static class Math
    {
        public const int Zero = 0;
        
        public static int AbsoluteValue(int x){
            return (x < 0) ? -x : x;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mult(int a, int b)
        {
            return a* b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

    }
}
