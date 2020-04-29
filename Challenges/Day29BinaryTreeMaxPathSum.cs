namespace ThirtyDayChallenge.Challenges
{
  public class Day29BinaryTreeMaxPathSum
  {
    /*
    Given a non-empty binary tree, find the maximum path sum.

    For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. The path must contain at least one node and does not need to go through the root.

    Example 1:

    Input: [1,2,3]

           1
          / \
        2   3

    Output: 6
    Example 2:

    Input: [-10,9,20,null,null,15,7]

      -10
      / \
      9  20
        /  \
      15   7

    Output: 42
    */

    public int MaxPathSum(TreeNode root)
    {
      if (root == null)
        return 0;

      return GetMaxSum(root, int.MinValue);
    }

    private int GetMaxSum(TreeNode node, int maxSumSoFar)
    {
      var leftSum = int.MinValue;
      var rightSum = int.MinValue;
      if (node.left != null)
      {
        leftSum = GetMaxSum(node.left, maxSumSoFar);
      }

      if (node.right != null)
      {
        rightSum = GetMaxSum(node.right, maxSumSoFar);
      }

      var maxNodeSum = int.MinValue;
      if (leftSum > rightSum)
      {
        if (leftSum + node.val > leftSum)
        {
          maxNodeSum = node.val + leftSum + rightSum;
        }
        else
        {
          maxNodeSum = leftSum;
        }
      }
      else
      {
        if (rightSum + node.val > rightSum)
        {
          maxNodeSum = node.val + leftSum + rightSum;
        }
        else
        {
          maxNodeSum = rightSum;
        }
      }

      maxNodeSum = maxNodeSum > node.val ? maxNodeSum : node.val;

      if (maxNodeSum > maxSumSoFar)
        return maxNodeSum;

      return maxSumSoFar;
    }
  }
}