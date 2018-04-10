using System.Collections.Generic;
using System.Linq;

namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given an array H of N positive integers 
    /// specifying the height of the wall, returns the minimum number of 
    /// blocks needed to build it.
    /// </summary>
    public class StoneWall
    {
        public int solution(int[] heightArray)
        {
            // Guard
            if(heightArray.Length <= 1)
            {
                return heightArray.Length;
            }

            // store progress;
            int blockCount = 0;
            Stack<int> stack = new Stack<int>();

            // iterate through the array
            for (int i = 0; i < heightArray.Length; i++)
            {
                // Check if any block heights are greater than the current
                int height = heightArray[i];
                while (stack.Count() != 0 && height < stack.Peek())
                {
                    stack.Pop();  
                }

                // Stack the current value if we don't have a value
                // or if he next height is less than the current height
                if(stack.Count == 0)
                {
                    stack.Push(height);
                    blockCount++;
                }
                else if (stack.Peek() < height)
                {
                    stack.Push(height);
                    blockCount++;
                }
            }

            // return
            return blockCount;
        }
    }
}
