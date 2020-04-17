using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var l1 = new ListNode(3)
      {
        next = new ListNode(9)
        {
          next = new ListNode(9)
          {
            next = new ListNode(9)
            {
              next = new ListNode(9)
              {
                next = new ListNode(9)
                {
                  next = new ListNode(9)
                  {
                    next = new ListNode(9)
                    {
                      next = new ListNode(9)
                      {
                        next = new ListNode(9)
                      }
                    }
                  }
                }
              }
            }
          }
        }
      };
      var l2 = new ListNode(7);

      var obj = new Day17AddTwoNumbersIIApproach2();
      var output = obj.AddTwoNumbers(l1, l2);
      while (output != null)
      {
        Console.WriteLine(output.val);
        output = output.next;
      }
    }
  }
}
