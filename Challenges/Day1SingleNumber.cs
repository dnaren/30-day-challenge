namespace ThirtyDayChallenge.Challenges
{
  public class Day1SingleNumber
  {
    //Given a non-empty array of integers, every element appears twice except for one. Find that single one.
    public int SingleNumber(int[] nums)
    {
      var num = 0;
      for (var i = 0; i < nums.Length; i++)
      {
        num = num ^ nums[i];
      }
      return num;
    }
  }
}