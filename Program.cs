using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var s = "a##c";
      var t = "#a#c";

      var obj = new Day9BackspaceStringCompare();
      var sln = obj.BackspaceCompare(s, t);
      Console.WriteLine(sln);
    }
  }
}
