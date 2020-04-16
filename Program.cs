using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = "**)))****";
      var obj = new Day16ValidParenthesisString();
      Console.WriteLine(obj.CheckValidString(input));
    }
  }
}
