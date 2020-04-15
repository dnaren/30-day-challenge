using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var s = "abc";
      var shift = new int[][] { new[] { 0, 1 }, new[] { 1, 1 } };
      var obj = new Day14PerformStringShifts();

      Console.WriteLine(obj.StringShift(s, shift));
    }
  }
}
