namespace ThirtyDayChallenge.Challenges
{
  public class Day11DiameterOfBinaryTree
  {
    public int DiameterOfBinaryTree(TreeNode root)
    {
      return GetLength(root, 0).Diameter;
    }

    public Lengths GetLength(TreeNode node, int maxSoFar)
    {
      if (node == null)
        return new Lengths
        {
          Length = 0,
          Diameter = maxSoFar
        };

      var leftSide = 0;
      var rightSide = 0;

      if (node.left != null)
      {
        Lengths lengths = GetLength(node.left, maxSoFar);
        leftSide = 1 + lengths.Length;

        if (lengths.Diameter > maxSoFar)
          maxSoFar = lengths.Diameter;
      }

      if (node.right != null)
      {
        Lengths lengths = GetLength(node.right, maxSoFar);
        rightSide = 1 + lengths.Length;

        if (lengths.Diameter > maxSoFar)
          maxSoFar = lengths.Diameter;
      }

      if (leftSide + rightSide > maxSoFar)
        maxSoFar = leftSide + rightSide;

      if (leftSide >= rightSide)
      {
        return new Lengths
        {
          Length = leftSide,
          Diameter = maxSoFar
        };
      }

      return new Lengths
      {
        Length = rightSide,
        Diameter = maxSoFar
      };
    }
  }

  public struct Lengths
  {
    public int Length;
    public int Diameter;
  }
}