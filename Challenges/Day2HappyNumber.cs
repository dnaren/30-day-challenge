using System;
using System.Collections.Generic;

namespace ThirtyDayChallenge.Challenges
{
  public class Day2HappyNumber
  {
    /*
    Write an algorithm to determine if a number is "happy".

    A happy number is a number defined by the following process: Starting with any positive integer, 
    replace the number by the sum of the squares of its digits, and repeat the process 
    until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. 
    Those numbers for which this process ends in 1 are happy numbers.

    */
    System.Collections.Generic.List<int> _unHappyNumbers = new List<int>();

    public bool IsHappy(int n)
    {
      if (_unHappyNumbers.Contains(n))
        return false;

      _unHappyNumbers.Add(n);

      var sum = 0;
      do
      {
        var i = n % 10;
        sum += i * i;
        n /= 10;
        Console.WriteLine($"{i}:{n}:{sum}");
      } while (n != 0);

      if (sum == 1)
        return true;

      Console.WriteLine(sum);
      return IsHappy(sum);
    }
  }

}