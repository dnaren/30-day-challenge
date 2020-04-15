using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {


      var s = "xqgwkiqpif";
      var shift = new int[][] {
        new[] { 1, 4 }
        , new[] { 0, 7 }
        , new[] { 0, 8 }
        , new[] { 0, 7 }
      , new[] { 0, 6 }
      , new[] { 1, 3 }
      , new[] { 0, 1 }
      , new[] { 1, 7 }
      , new[] { 0, 5 }
      , new[] { 0, 6 }};
      var obj = new Day14PerformStringShifts();

      Console.WriteLine(obj.StringShift(s, shift));
    }
  }
}
