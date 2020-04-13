using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] input = { };
      var obj = new Day12LastStoneWeight();

      Console.WriteLine(obj.LastStoneWeight(input));
    }
  }
}
