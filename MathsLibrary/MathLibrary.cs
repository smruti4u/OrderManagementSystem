using System;

namespace MathsLibrary
{
    public class MathLibrary : IMathLibrary
    {
        public bool doCalculation { get {


                return false; } }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
