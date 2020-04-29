using System;
using System.Collections.Generic;
using ThirtyDayChallenge.Challenges;
namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var firstUnique = new FirstUnique(new[] { 2, 3, 5 });
      Console.WriteLine(firstUnique.ShowFirstUnique());
      firstUnique.Add(5);
      Console.WriteLine(firstUnique.ShowFirstUnique());
      firstUnique.Add(2);
      Console.WriteLine(firstUnique.ShowFirstUnique());
      firstUnique.Add(3);
      Console.WriteLine(firstUnique.ShowFirstUnique());
    }
  }
}
//ghbrc
