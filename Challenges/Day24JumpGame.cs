namespace ThirtyDayChallenge.Challenges
{
  public class Day24JumpGame
  {
    public bool CanJump(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return false;

      var position = nums.Length - 1;
      for (int i = nums.Length - 1; i >= 0; i--)
      {
        if (i + nums[i] >= position)
        {
          position = i;
        }
      }

      return position == 0;
    }

    private bool CanJump2(int[] nums, int curPosition)
    {
      if (curPosition == nums.Length - 1)
        return true;
      else if (curPosition >= nums.Length)
        return false;

      var jumps = nums[curPosition];
      var hasReachedLast = false;
      while (hasReachedLast == false
        && jumps > 0
        && curPosition < nums.Length)
      {
        if (hasReachedLast == false)
        {
          hasReachedLast = CanJump2(nums, curPosition + jumps);
        }
        jumps--;
      }

      return hasReachedLast;
    }
  }
}