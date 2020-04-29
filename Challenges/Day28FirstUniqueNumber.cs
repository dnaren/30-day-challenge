using System.Collections;
using System.Collections.Generic;
namespace ThirtyDayChallenge.Challenges
{
  public class FirstUnique
  {
    private readonly int[] nums;
    private Dictionary<int, int> map = new Dictionary<int, int>();
    private Queue<int> queue = new Queue<int>();
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
      queue.Enqueue(key);

      if (!map.ContainsKey(key))
      {
        map.Add(key, 1);
      }
      else
      {
        map[key] += 1;
      }
    }

    public int ShowFirstUnique()
    {
      while (queue.TryPeek(out int key))
      {
        if (map[key] == 1)
          return key;
        else
          queue.Dequeue();
      }
      return -1;
    }
  }
}