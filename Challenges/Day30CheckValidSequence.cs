namespace ThirtyDayChallenge.Challenges
{
  public class Day30CheckValidSequence
  {
    public bool IsValidSequence(TreeNode root, int[] arr)
    {
      if (root == null || arr == null || arr.Length == 0)
        return false;

      return DepthFirstSearch(root, arr, 0);
    }

    private bool DepthFirstSearch(TreeNode node, int[] arr, int position)
    {
      if (node == null)
        return false;

      var isMatching = node.val == arr[position];
      position++;

      if (isMatching && position == arr.Length)
      {
        if (node.left == null && node.right == null)
          return true;
        else
          return false;
      }

      return isMatching
        && (DepthFirstSearch(node.left, arr, position) || DepthFirstSearch(node.right, arr, position));
    }
  }
}