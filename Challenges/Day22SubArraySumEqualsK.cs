namespace ThirtyDayChallenge.Challenges
{
  public class Day22SubArraySumEqualsK
  {
    /*
    Given an array of integers and an integer k, you need to find the total number of continuous subarrays 
    whose sum equals to k.

    Example 1:
    Input:nums = [1,1,1], k = 2
    Output: 2
    Note:
    The length of the array is in range [1, 20,000].
    The range of numbers in the array is [-1000, 1000] and the range of the integer k is [-1e7, 1e7].
    */

    public int SubarraySum(int[] nums, int k)
    {
      if (nums == null)
        return 0;

      var noOfSubArrays = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        var sum = 0;
        for (int j = i; j < nums.Length; j++)
        {
          sum += nums[j];
          if (sum == k)
          {
            noOfSubArrays++;
          }
        }
      }

      return noOfSubArrays;
    }
  }
}