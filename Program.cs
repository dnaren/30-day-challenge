using System.Diagnostics;
using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new[] { 4, 5, 6, 7, 0, 1, 2 };
      var target = 3;

      var obj = new Day19SearchInRotatedSortedArrary();
      var s = new Stopwatch();
      s.Start();
      var output = obj.Search(input, target);
      s.Stop();
      Console.WriteLine($"{output}:{s.ElapsedMilliseconds}");
    }
  }
}
