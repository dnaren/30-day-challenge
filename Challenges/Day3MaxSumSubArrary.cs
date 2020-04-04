using System;

namespace ThirtyDayChallenge.Challenges
{
  public class Day3MaxSumSubArrary
  {
    public int MaxSubArray(int[] nums)
    {

      //Uses the Dynamic Programming - Kadane's Algorithm
      //https://www.baeldung.com/java-maximum-subarray

      int size = nums.Length;
      int start = 0;
      int end = 0;

      int maxSoFar = 0, maxEndingHere = 0;

      for (int i = 0; i < size; i++)
      {
        if (nums[i] > maxEndingHere + nums[i])
        {
          start = i;
          maxEndingHere = nums[i];
        }
        else
          maxEndingHere = maxEndingHere + nums[i];

        if (maxSoFar < maxEndingHere)
        {
          maxSoFar = maxEndingHere;
          end = i;
        }
      }

      return maxSoFar;
    }
  }
}