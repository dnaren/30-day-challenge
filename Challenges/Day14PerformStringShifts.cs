using System;
namespace ThirtyDayChallenge.Challenges
{
  public class Day14PerformStringShifts
  {
    /*
    You are given a string s containing lowercase English letters, and a matrix shift, where shift[i] = [direction, amount]:

    direction can be 0 (for left shift) or 1 (for right shift). 
    amount is the amount by which string s is to be shifted.
    A left shift by 1 means remove the first character of s and append it to the end.
    Similarly, a right shift by 1 means remove the last character of s and add it to the beginning.
    Return the final string after all operations.



    Example 1:

    Input: s = "abc", shift = [[0,1],[1,2]]
    Output: "cab"
    Explanation: 
    [0,1] means shift to left by 1. "abc" -> "bca"
    [1,2] means shift to right by 2. "bca" -> "cab"
    Example 2:

    Input: s = "abcdefg", shift = [[1,1],[1,1],[0,2],[1,3]]
    Output: "efgabcd"
    Explanation:  
    [1,1] means shift to right by 1. "abcdefg" -> "gabcdef"
    [1,1] means shift to right by 1. "gabcdef" -> "fgabcde"
    [0,2] means shift to left by 2. "fgabcde" -> "abcdefg"
    [1,3] means shift to right by 3. "abcdefg" -> "efgabcd"

    Constraints:

    1 <= s.length <= 100
    s only contains lower case English letters.
    1 <= shift.length <= 100
    shift[i].length == 2
    0 <= shift[i][0] <= 1
    0 <= shift[i][1] <= 100

    */

    public string StringShift(string s, int[][] shift)
    {
      return Shift(s, shift);
    }

    private string Shift(string s, int[][] shifts)
    {
      foreach (var shift in shifts)
      {
        var shiftBy = shift[1];

        if (shift[0] == 0)
        {
          //left shift
          var left = s.Substring(0, shiftBy);
          var right = s.Substring(shiftBy, s.Length - shiftBy);

          s = $"{right}{left}";
        }
        else
        {
          //right shift
          var left = s.Substring(0, s.Length - shiftBy);
          var right = s.Substring(s.Length - shiftBy, shiftBy);

          s = $"{right}{left}";
        }
      }
      return s;
    }

    private string ShiftOptimal(string s, int[][] shifts)
    {
      var finalShift = 0;

      foreach (var shift in shifts)
      {
        var shiftBy = shift[1];
        if (shift[0] == 0)
        {
          //left shift
          finalShift += shiftBy;
        }
        else
        {
          //right shift
          finalShift -= shiftBy;
        }
      }

      Console.WriteLine(finalShift);

      if (finalShift > 0)
      {
        if (s.Length >= finalShift)
        //left shift
        {
          var left = s.Substring(0, finalShift);
          var right = s.Substring(finalShift, s.Length - finalShift);

          s = $"{right}{left}";
        }
      }
      else if (finalShift < 0)
      {
        finalShift = System.Math.Abs(finalShift);
        //right shift
        if (s.Length >= finalShift)
        {
          var left = s.Substring(0, s.Length - finalShift);
          var right = s.Substring(s.Length - finalShift, finalShift);

          s = $"{right}{left}";
        }
      }

      return s;
    }
  }
}