using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new[] { 1 };
      var obj = new Day15ProductOfArrayExceptSelf();
      foreach (var item in obj.ProductExceptSelf(input))
      {
        Console.WriteLine(item);
      }
    }
  }
}
