using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new ListNode(1)
      {
        next = new ListNode(2)
        {
          next = new ListNode(3)
          {
            next = new ListNode(4)
            {
              next = new ListNode(5)
            }
          }
        }
      };

      var obj = new Day8ReverseSingleLinkedList();
      var sln = obj.Reverse(input);
      Console.WriteLine(sln.val);
    }
  }
}
