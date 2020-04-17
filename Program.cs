using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new ListNode(3)
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
      var input2 = new ListNode(7);
      var obj = new Day16AddTwoNumbersII();
      var output = obj.AddTwoNumbers(input, input2);
      while (output != null)
      {
        Console.WriteLine(output.val);
        output = output.next;
      }
    }
  }
}
