using System;
using System.Collections.Generic;
using ThirtyDayChallenge.Challenges;
namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var obj = new Day29BinaryTreeMaxPathSum();
      var input = new TreeNode(-2)
      {
        //left = new TreeNode(-1),
        right = new TreeNode(-3)
      };
      // {
      //   left = new TreeNode(9)
      //   {
      //     left = new TreeNode(30)
      //   },
      //   right = new TreeNode(20)
      //   {
      //     left = new TreeNode(15),
      //     right = new TreeNode(7)
      //   }
      // };

      Console.WriteLine(obj.MaxPathSum(input));
    }
  }
}
//ghbrc
