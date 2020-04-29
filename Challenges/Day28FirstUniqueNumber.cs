using System.Collections.Generic;
namespace ThirtyDayChallenge.Challenges
{
  public class FirstUnique
  {
    private readonly int[] nums;
    private Dictionary<int, int> map = new Dictionary<int, int>();
    private LinkedList<int> uniqueList = new LinkedList<int>();
    public FirstUnique(int[] nums)
    {
      this.nums = nums;

      foreach (var num in nums)
      {
        Add(num);
      }
    }

    public void Add(int key)
    {
      if (!map.ContainsKey(key))
      {
        map.Add(key, 1);
        uniqueList.AddLast(key);
      }
      else
      {
        map[key] += 1;
        uniqueList.Remove(key);
      }
    }

    public int ShowFirstUnique()
    {
      return uniqueList.First?.Value ?? -1;
    }
  }
}