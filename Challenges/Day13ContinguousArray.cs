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
      var maxLength = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        var numOfZeros = 0;
        var numOfOnes = 0;

        for (int j = i; j < nums.Length; j++)
        {
          if (nums[j] == 0)
            numOfZeros++;
          else
            numOfOnes++;

          if (numOfOnes == numOfZeros && (j - i + 1) > maxLength)
          {
            maxLength = (j - i + 1);
          }
        }
      }

      return maxLength;
    }
  }
}