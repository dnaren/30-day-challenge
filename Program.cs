using System.Linq;
using System;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new[] { 1, 1, 2 };
      var obj = new Challenges.Day7CountingElements();
      var sln = obj.CountElements(input);
      Console.WriteLine(sln);
    }
  }
}
