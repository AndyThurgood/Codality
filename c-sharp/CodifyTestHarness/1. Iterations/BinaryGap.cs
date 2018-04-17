using System;
using System.Collections.Generic;
using System.Linq;

namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given a positive integer N, returns the length 
    /// of its longest binary gap.The function should return 0 if N doesn't 
    /// contain a binary gap.
    /// </summary>
    public class BinaryGap
    {
        public int solution(int number)
        {
            // Set the default return and get a binary representation of the number arguement
            int minimalReturnValue = 0;

            // If we get a zero then we can't do anything
            if(number == 0){
                return minimalReturnValue;
            }

            // Convert to binary
            string binaryRepresentation = Convert.ToString(number, 2);

            // Remove trailing zeros
            binaryRepresentation = binaryRepresentation.Remove(binaryRepresentation.LastIndexOf('1'));

            // Split the binary string down into a list of strings (1's and 0's)
            IEnumerable<string> binaryGaps = binaryRepresentation.Aggregate(" ", (x, y) => x + (x.Last() == y ? "" : " ") + y)
                                                          .Trim()
                                                          .Split(' ');

            // Check if we have split more than once, if not bail out and return 0
            if(binaryGaps.Count() <= 1)
            {
                return minimalReturnValue;
            }

            // iterate over the list and get the longest string
            int derivedReturnValue = binaryGaps.Aggregate((x, y) => x.Length > y.Length ? x : y).Length;

            // Return a positive value
            return derivedReturnValue; 

        }
    }
}
