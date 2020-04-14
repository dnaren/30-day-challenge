using System;
using System.Collections.Generic;
namespace ThirtyDayChallenge.Challenges
{
  public class Day13ContinguousArray
  {
    /*
    Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.

    Example 1:
    Input: [0,1]
    Output: 2
    Explanation: [0, 1] is the longest contiguous subarray with equal number of 0 and 1.
    Example 2:
    Input: [0,1,0]
    Output: 2
    Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
    Note: The length of the given binary array will not exceed 50,000.
    */

    public int FindMaxLength(int[] nums)
    {
      var zeroSumSubArrays = new Dictionary<int, int>();
      zeroSumSubArrays.Add(0, -1);

      var maxLength = 0;
      var sum = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] == 0)
          sum--;
        else
          sum++;

        if (zeroSumSubArrays.ContainsKey(sum))
        {
          maxLength = Math.Max(maxLength, i - zeroSumSubArrays[sum]);
        }
        else
        {
          zeroSumSubArrays.Add(sum, i);
        }
      }

      return maxLength;
    }
  }
}