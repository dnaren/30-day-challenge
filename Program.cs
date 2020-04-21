using System.Diagnostics;
using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new[] { 8, 5, 1, 7, 10, 12 };

      var obj = new Day20ConstructBinarySearchTreePreOrderTraversal();
      var s = new Stopwatch();
      s.Start();
      var output = obj.BstFromPreorder(input);
      s.Stop();
    }
  }
}
