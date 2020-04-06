using System;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new[] { 7, 6, 4, 3, 1 };
      var obj = new Challenges.Day5BuyAndSellStock();
      var sln = obj.MaxProfit(input);
      Console.WriteLine(sln);
    }
  }
}
