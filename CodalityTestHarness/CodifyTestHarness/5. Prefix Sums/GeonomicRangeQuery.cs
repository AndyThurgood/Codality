using System;
using System.Collections.Generic;
using System.Linq;

namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given a non-empty zero-indexed string S 
    /// consisting of N characters and two non-empty zero-indexed arrays 
    /// P and Q consisting of M integers, returns an array consisting 
    /// of M integers specifying the consecutive answers to all queries
    /// </summary>
    public class GeonomicRangeQuery
    {
        public int[] solution(string sequence, int[] leftArray, int[] rightArray)
        {
            // Gaurd against empty arrays
            if(leftArray.Length == 0 ){
                throw new ArgumentNullException(nameof(leftArray)); 
            }

            if (rightArray.Length == 0)
            {
                throw new ArgumentNullException(nameof(rightArray));
            }

            // Store the subsequence min values
            List<int> returnList = new List<int>();

            // Use the first array as our enumerator
            for (int i = 0; i < leftArray.Length; i++)
            {
                // Get the substring
                string subsequence = sequence.Substring(leftArray[i], (rightArray[i] - leftArray[i]) + 1);

                // Get the associated enum, find the lowest value
                returnList.Add(subsequence.Select(x => (int)Enum.Parse(typeof(Nucleotides), x.ToString())).Min());
            }

            return returnList.ToArray();
        }

        /// <summary>
        /// Nucleotides values
        /// </summary>
        enum Nucleotides
        {
            A = 1,
            C = 2,
            G = 3,
            T = 4
        }
    }
}
