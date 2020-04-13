using System.Linq;

namespace ThirtyDayChallenge.Challenges
{
  public class Day12LastStoneWeight
  {
    /*
    We have a collection of stones, each stone has a positive integer weight.

    Each turn, we choose the two heaviest stones and smash them together.  Suppose the stones have weights x and y with x <= y.  The result of this smash is:

    If x == y, both stones are totally destroyed;
    If x != y, the stone of weight x is totally destroyed, and the stone of weight y has new weight y-x.
    At the end, there is at most 1 stone left.  Return the weight of this stone (or 0 if there are no stones left.)

    

    Example 1:

    Input: [2,7,4,1,8,1]
    Output: 1
    Explanation: 
    We combine 7 and 8 to get 1 so the array converts to [2,4,1,1,1] then,
    we combine 2 and 4 to get 2 so the array converts to [2,1,1,1] then,
    we combine 2 and 1 to get 1 so the array converts to [1,1,1] then,
    we combine 1 and 1 to get 0 so the array converts to [1] then that's the value of last stone.
    

    Note:

    1 <= stones.length <= 30
    1 <= stones[i] <= 1000
    */
    public int LastStoneWeight(int[] stones)
    {
      while (stones.Length > 1)
      {
        stones = Heapify(stones);

        var outcome = Smash(stones[stones.Length - 2], stones[stones.Length - 1]);
        if (outcome == 0)
        {
          stones = stones.Take(stones.Length - 2).ToArray();
        }
        else
        {
          stones = stones.Take(stones.Length - 1).ToArray();
          stones[stones.Length - 1] = outcome;
        }
      }
      if (stones.Length == 1)
        return stones[0];

      return 0;
    }

    private int[] Heapify(int[] stones)
    {
      var stonesList = stones.ToList();
      stonesList.Sort();

      return stonesList.ToArray();
    }

    private int Smash(int x, int y)
    {
      if (x == y)
        return 0;

      return y - x;
    }
  }
}