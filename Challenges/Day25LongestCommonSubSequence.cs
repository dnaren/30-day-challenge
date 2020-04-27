using System;
using System.Collections.Generic;

namespace ThirtyDayChallenge.Challenges
{
  public class Day25LongestCommonSubSequence
  {
    /*
    Given two strings text1 and text2, return the length of their longest common subsequence.

    A subsequence of a string is a new string generated from the original string with some
     characters(can be none) deleted without changing the relative order of the remaining characters.
     (eg, "ace" is a subsequence of "abcde" while "aec" is not). A common subsequence of two strings 
     is a subsequence that is common to both strings.

    If there is no common subsequence, return 0.

    Example 1:

    Input: text1 = "abcde", text2 = "ace" 
    Output: 3  
    Explanation: The longest common subsequence is "ace" and its length is 3.
    Example 2:

    Input: text1 = "abc", text2 = "abc"
    Output: 3
    Explanation: The longest common subsequence is "abc" and its length is 3.
    Example 3:

    Input: text1 = "abc", text2 = "def"
    Output: 0
    Explanation: There is no such common subsequence, so the result is 0.


    Constraints:

    1 <= text1.length <= 1000
    1 <= text2.length <= 1000
    The input strings consist of lowercase English characters only.
    */

    public int LongestCommonSubsequence(string text1, string text2)
    {
      if (text1 == null || text2 == null || text1.Length == 0 || text2.Length == 0)
      {
        return 0;
      }

      return GetLongestLength(text1, text2, text1.Length, text2.Length);
    }

    private int GetLongestLength(string x, string y, int m, int n)
    {

      if (m == 0 || n == 0)
      {
        return 0;
      }

      if (x[m - 1] == y[n - 1])
      {
        return GetLongestLength(x, y, m - 1, n - 1) + 1;
      }

      return Math.Max(GetLongestLength(x, y, m, n - 1),
              GetLongestLength(x, y, m - 1, n));
    }
  }
}