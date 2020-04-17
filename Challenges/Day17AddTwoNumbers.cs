namespace ThirtyDayChallenge.Challenges
{
  public class Day17AddTwoNumbers
  {
    /*
    You are given two non-empty linked lists representing two non-negative integers. 
    The digits are stored in reverse order and each of their nodes contain a single digit. 
    Add the two numbers and return it as a linked list.

    You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    Example:

    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8
    Explanation: 342 + 465 = 807.
    */
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
      if (l1 == null && l2 == null)
        return null;
      else if (l1 == null && l2 != null)
        return l2;
      else if (l1 != null && l2 == null)
        return l1;

      l1 = Reverse(l1);
      l2 = Reverse(l2);

      var l1Length = GetLength(l1);
      var l2Length = GetLength(l2);

      if (l1Length > l2Length)
      {
        l2 = PadEmptyNodes(l2, l1Length - l2Length);
      }
      else
      {
        l1 = PadEmptyNodes(l1, l2Length - l1Length);
      }
      var carry = 0;
      var output = Add(l1, l2, out carry);
      if (carry == 1)
        output = new ListNode(1)
        {
          next = output
        };
      return Reverse(output);
    }

    private ListNode Add(ListNode l1, ListNode l2, out int carry)
    {
      ListNode next = null;
      carry = 0;

      if (l1.next != null)
      {
        next = Add(l1.next, l2.next, out carry);
      }

      var addition = carry + l1.val + l2.val;
      var val = 0;
      if (addition > 9)
      {
        val = addition % 10;
        carry = 1;
      }
      else
      {
        val = addition;
        carry = 0;
      }

      var node = new ListNode(val)
      {
        next = next
      };

      return node;
    }

    private ListNode PadEmptyNodes(ListNode node, int paddingLength)
    {
      while (paddingLength > 0)
      {
        node = new ListNode(0)
        {
          next = node
        };
        paddingLength--;
      }

      return node;
    }

    private int GetLength(ListNode node)
    {
      if (node == null)
        return 0;

      return 1 + GetLength(node.next);
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