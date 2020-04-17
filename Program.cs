using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      char[][] grid = new[] {
        new char[] { '1', '0', '1', '1', '0' },
        new char[] { '1', '0', '1', '0', '1' }
      };

      var obj = new Day17NumberOfIslands();
      var output = obj.NumIslands(grid);
      Console.WriteLine(output);
    }
  }
}
