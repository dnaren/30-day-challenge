using System.Linq;
namespace ThirtyDayChallenge.Challenges
{
  public class Day19SearchInRotatedSortedArrary
  {
    /*
    Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

    (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

    You are given a target value to search. If found in the array return its index, otherwise return -1.

    You may assume no duplicate exists in the array.

    Your algorithm's runtime complexity must be in the order of O(log n).

    Examples:

    Input: nums = [0,1,2,4,5,6,7], target = 0
    Output: 0

    Input: nums = [4,5,6,7,0,1,2], target = 0
    Output: 4
    
    Input: nums = [4,5,6,7,0,1,2], target = 3
    Output: -1

    Input: nums = [4,5,6,7,0,1,2], target = 4
    Output: 0

    Input: nums = [4,5,6,7,8,9,1,2], target = 7
    Output: 3

    Input: nums = [5,6,7,8,1,2,4], target = 4
    Output: 6

    Input: nums = [5,6,7,8,1,2,3,4], target = 8
    Output: 6

    Input: nums = [5,6,7,0,1,2,4], target = 6
    Output: 1
    */

    public int Search(int[] nums, int target)
    {
      if (nums == null || nums.Length == 0)
      {
        return -1;
      }

      var left = 0;
      var right = nums.Length - 1;

      while (left < right)
      {
        var midpoint = left + (right - left) / 2;
        if (nums[midpoint] > nums[right])
        {
          left = midpoint + 1;
        }
        else
        {
          right = midpoint;
        }
      }

      var rotatedIndex = left;
      if (nums[rotatedIndex] <= target && target <= nums[nums.Length - 1])
      {
        left = rotatedIndex;
        right = nums.Length - 1;
      }
      else
      {
        left = 0;
        right = rotatedIndex;
      }

      while (left <= right)
      {
        var midpoint = left + (right - left) / 2;
        if (nums[midpoint] == target)
          return midpoint;
        else if (nums[midpoint] < target)
          left = midpoint + 1;
        else
          right = midpoint - 1;
      }

      return -1;
    }
  }
}