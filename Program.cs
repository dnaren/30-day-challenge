using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {

      var obj = new Day16UnCommonWords();
      var output = obj.UncommonFromSentences("this apple is sweet", "this apple is sour");
      foreach (var s in output)
      {
        Console.WriteLine(s);
      }
    }
  }
}
