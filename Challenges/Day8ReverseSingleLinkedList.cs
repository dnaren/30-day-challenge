namespace ThirtyDayChallenge.Challenges
{
  public class Day8ReverseSingleLinkedList
  {
    public ListNode Reverse(ListNode head)
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