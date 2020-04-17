using System;
namespace ThirtyDayChallenge.Challenges
{
  public class Day16AddTwoNumbersII
  {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
      uint output = GetValue(0, l1) + GetValue(0, l2);
      Console.WriteLine(output);
      return Reverse(BuildListNodes(output));
    }

    private uint GetValue(uint prevValue, ListNode l)
    {
      uint val = (uint)(prevValue * 10 + l.val);
      if (l.next != null)
      {
        val = GetValue(val, l.next);
      }
      return val;
    }

    private ListNode BuildListNodes(uint num)
    {
      int val = (int)(num % 10);
      num = num / 10;
      var node = new ListNode(val);
      if (num > 0)
      {
        node.next = BuildListNodes(num);
      }

      return node;
    }

    private ListNode Reverse(ListNode head)
    {
      ListNode prevNode = null, currentNode = head, nextNode = currentNode.next;

      while (nextNode != null)
      {
        nextNode = currentNode.next;
        currentNode.next = prevNode;

        prevNode = currentNode;
        currentNode = nextNode;
        nextNode = currentNode.next;
      }

      currentNode.next = prevNode;

      return currentNode;
    }
  }
}