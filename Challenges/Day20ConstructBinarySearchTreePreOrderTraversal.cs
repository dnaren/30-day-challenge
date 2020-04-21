namespace ThirtyDayChallenge.Challenges
{
  public class Day20ConstructBinarySearchTreePreOrderTraversal
  {
    /*
    Return the root node of a binary search tree that matches the given preorder traversal.

    (Recall that a binary search tree is a binary tree where for every node, any descendant of node.left has a value < node.val, and any descendant of node.right has a value > node.val.  Also recall that a preorder traversal displays the value of the node first, then traverses node.left, then traverses node.right.)



    Example 1:

    Input: [8,5,1,7,10,12]
    Output: [8,5,10,1,7,null,12]

    Note: 
    1 <= preorder.length <= 100
    The values of preorder are distinct.
    */
    public TreeNode BstFromPreorder(int[] preorder)
    {
      if (preorder == null || preorder.Length == 0)
      {
        return null;
      }

      var rootNode = new TreeNode(preorder[0]);
      var i = 1;

      while (i < preorder.Length)
      {
        AddNode(rootNode, preorder[i]);
        i++;
      }

      return rootNode;
    }

    private TreeNode AddNode(TreeNode node, int newValue)
    {
      if (newValue < node.val)
      {
        if (node.left == null)
          node.left = new TreeNode(newValue);
        else
          AddNode(node.left, newValue);

      }
      else
      {
        if (node.right == null)
          node.right = new TreeNode(newValue);
        else
          AddNode(node.right, newValue);
      }

      return node;
    }
  }
}