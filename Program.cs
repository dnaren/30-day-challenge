using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var s = "nnnnnnnn";
      var obj = new Day17LongestSubString();
      var output = obj.LengthOfLongestSubstring(s);
      Console.WriteLine(output);
    }
  }
}
