namespace ThirtyDayChallenge.Challenges
{
  public class Day15ProductOfArrayExceptSelf
  {
    /*
    Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

    Example:

    Input:  [1,2,3,4]
    Output: [24,12,8,6]
    Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.

    Note: Please solve it without division and in O(n).

    Follow up:
    Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)
    */

    public int[] ProductExceptSelf(int[] nums)
    {
      if (nums.Length == 1)
        return new[] { 0 };

      int[] left = new int[nums.Length];
      left[0] = 1;

      int[] right = new int[nums.Length];
      right[nums.Length - 1] = 1;

      for (int i = 1, j = nums.Length - 2; i < nums.Length; i++, j--)
      {
        left[i] = left[i - 1] * nums[i - 1];
        right[j] = right[j + 1] * nums[j + 1];
      }

      int[] output = new int[nums.Length];
      for (int i = 0; i < nums.Length; i++)
      {
        output[i] = left[i] * right[i];
      }

      return output;
    }
  }
}