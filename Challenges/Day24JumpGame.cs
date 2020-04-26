namespace ThirtyDayChallenge.Challenges
{
  public class Day24JumpGame
  {
    public bool CanJump(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return false;

      return CanJump2(nums, 0);
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