using System.Diagnostics;
using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new[] { 1, 1, 1 };
      var k = 2;

      var obj = new Day22SubArraySumEqualsK();
      var s = new Stopwatch();
      s.Start();
      var output = obj.SubarraySum(input, k);
      s.Stop();
      Console.WriteLine($"{output}:{s.ElapsedMilliseconds}");
    }
  }
}
