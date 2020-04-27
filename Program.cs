using System.Diagnostics;
using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {

      var obj = new Day25LongestCommonSubSequence();
      var s = new Stopwatch();
      s.Start();
      var output = obj.LongestCommonSubsequence("pmjghexybyrgzczy", "hafcdqbgncrcbihkd");
      s.Stop();
      Console.WriteLine($"{output}:{s.ElapsedMilliseconds}");
    }
  }
}
//ghbrc
