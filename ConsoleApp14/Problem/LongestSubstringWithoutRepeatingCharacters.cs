using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem
{
    //https://leetcode.com/submissions/detail/420199039/
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int Test(string s)
        {
            return (LengthOfLongestSubstring(s));
        }

        private static int LengthOfLongestSubstring(string s)
        {
            var tempStr = "";
            var result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var currentLetter = s[i];

                //Reinit
                var indxOfCurrentLetterDbl = tempStr.IndexOf(currentLetter);
                if (indxOfCurrentLetterDbl != -1)
                    tempStr = tempStr.Remove(0, indxOfCurrentLetterDbl == 0 ? 1 : indxOfCurrentLetterDbl + 1);

                if (tempStr.Length == 0 || (tempStr[tempStr.Length - 1] != currentLetter))
                    tempStr = string.Concat(tempStr, currentLetter);

                //Keep the hightest
                if (tempStr.Length > result)
                    result = tempStr.Length;
            }
            tempStr = null;
            return result;
        }
    }
}
