using System;

namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given three integers X, Y and D, returns 
    /// the minimal number of jumps from position X to a position equal 
    /// to or greater than Y.
    /// </summary>
    public class FrogJump
    {
        public int solution(int x, int y, int d)
        {
            // Number of hops
            int returnValue = 0;

            // do the math
            returnValue = (int)Math.Ceiling((double)(y - x) / d); ;

            // Iterate until x exceeds y
            //while (y > x)
            //{
            //    x += d;
            //    returnValue++;
            //}

            // Return the result
            return returnValue;
        }
    }
}