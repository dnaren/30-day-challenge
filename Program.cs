using System;
using ThirtyDayChallenge.Challenges;

namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var root = new TreeNode(1)
      {
        left = new TreeNode(2)
        {
          left = new TreeNode(4)
          {
            left = new TreeNode(8),
            right = new TreeNode(9)
            {
              left = new TreeNode(10),
              right = new TreeNode(11)
            }
          },
          right = new TreeNode(5)
          {
            left = new TreeNode(6),
            right = new TreeNode(7)
            {
              left = new TreeNode(12),
              right = new TreeNode(13)
            }
          }
        },
        right = new TreeNode(3)
      };
      var obj = new Day11DiameterOfBinaryTree();

      Console.WriteLine(obj.DiameterOfBinaryTree(root));
    }
  }
}
