using System;
using System.Collections.Generic;
using System.Linq;
namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given a string S consisting of N characters, 
    /// returns 1 if S is properly nested and 0 otherwise.
    /// </summary>
    public class Brackets
    {
        public int solution(string stringToParse)
        {
            // Gaurd against empty
            if(string.IsNullOrEmpty(stringToParse))
            {
                return 1;
            }

            // Guard against un-even char counts
            if(stringToParse.Length % 2 != 0)
            {
                return 0;
            }

            Dictionary<char, char> brackets = new Dictionary<char, char> { { '{', '}' }, { '(', ')' }, { '[', ']' } };
            Stack<char> openedBrackets = new Stack<char>();

            foreach(char character in stringToParse)
            {
                // Add to the stack
                if(brackets.ContainsKey(character))
                {
                    openedBrackets.Push(character);
                }
                // We have encountered a closing bracket or char before 
                // and opening bracket so bail out
                else if(openedBrackets.Count() == 0)
                {
                    return 0;
                }
                // The last opened char added to the stack
                // does not match expected closing bracket
                else if(character != brackets[openedBrackets.Pop()])
                {
                    return 0;
                }
            }

            if(openedBrackets.Count != 0)
            {
                return 0;
            }

            return 1;
        }
    }
}
