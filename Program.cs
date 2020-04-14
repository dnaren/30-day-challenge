using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      //int[] input = { };
      //int[] input = { 1, 0 };
      //int[] input = { 1, 0, 1 };
      //int[] input = { 1, 0, 1, 0 };
      int[] input = { 1, 0, 1, 1, 1, 0, 0 };
      var obj = new Day13ContinguousArray();

      Console.WriteLine(obj.FindMaxLength(input));
    }
  }
}
