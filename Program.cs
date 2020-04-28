using System.Diagnostics;
using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      // char[][] input = new[]
      // {
      //   new char[] { '1', '0', '1', '0', '0' },
      //   new char[] { '1', '0', '1', '1', '1' },
      //   new char[] { '1', '1', '0', '0', '1' },
      //   new char[] { '1', '0', '0', '1', '0' },
      // };
      char[][] input = new char[0][];
      var obj = new Day26MaximalSquare();
      var s = new Stopwatch();
      s.Start();
      var output = obj.MaximalSquare(input);
      s.Stop();
      Console.WriteLine($"{output}:{s.ElapsedMilliseconds}");
    }
  }
}
//ghbrc
