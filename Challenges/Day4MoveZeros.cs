namespace ThirtyDayChallenge.Challenges
{
  public class Day4MoveZeros
  {
    public void MoveZeroes(int[] nums)
    {
      if (nums.Length > 1)
      {
        var nonZeroIndex = 0;
        for (var i = 0; i < nums.Length; i++)
        {
          if (nums[i] != 0)
          {
            nums[nonZeroIndex] = nums[i];
            nonZeroIndex++;
          }
        }
        for (var i = nonZeroIndex; i < nums.Length; i++)
        {
          nums[i] = 0;
        }
      }
    }
  }
  s