using System;
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

      var result = new Result { Value = int.MinValue };
      GetMaxSum2(root, result);
      return result.Value;
    }

    private int GetMaxSum2(TreeNode node, Result result)
    {
      if (node == null)
        return 0;

      var leftSum = GetMaxSum2(node.left, result);
      var rightSum = GetMaxSum2(node.right, result);

      var maxSingle = Math.Max(Math.Max(leftSum, rightSum) + node.val, node.val);
      var maxTop = Math.Max(maxSingle, leftSum + rightSum + node.val);
      result.Value = Math.Max(result.Value, maxTop);

      return maxSingle;
    }

    public class Result
    {
      public int Value { get; set; }
    }

    // private int GetMaxSum(TreeNode node)
    // {
    //   var nodeSum = node.val;
    //   var leftSum = int.MinValue;
    //   var rightSum = int.MinValue;

    //   if (node.left != null)
    //   {
    //     leftSum = GetMaxSum(node.left);
    //     nodeSum += leftSum;
    //   }

    //   if (node.right != null)
    //   {
    //     rightSum = GetMaxSum(node.right);
    //     nodeSum += rightSum;
    //   }

    //   if (node.left == null && node.right == null)
    //     return node.val;

    //   if (nodeSum > leftSum && nodeSum > rightSum)
    //   {
    //     if (nodeSum > node.val)
    //       return nodeSum;

    //     return node.val;
    //   }

    //   if (leftSum > rightSum)
    //     return leftSum;
    //   else
    //     return rightSum;
    // }
  }
}