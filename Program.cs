using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      MinStack minStack = new MinStack();
      minStack.Push(-2);
      minStack.Push(0);
      minStack.Push(-3);
      Console.WriteLine(minStack.GetMin());
      minStack.Pop();
      Console.WriteLine(minStack.Top());
      Console.WriteLine(minStack.GetMin());
    }
  }
}
