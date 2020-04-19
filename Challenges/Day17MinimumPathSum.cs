namespace ThirtyDayChallenge.Challenges
{
  public class Day17MinimumPathSum
  {
    /*
    Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right 
    which minimizes the sum of all numbers along its path.

    Note: You can only move either down or right at any point in time.

    Example:

    Input:
    [
      [1,3,1],
      [1,5,1],
      [4,2,1]
    ]
    Output: 7
    Explanation: Because the path 1→3→1→1→1 minimizes the sum.
    */
    public int MinPathSum(int[][] grid)
    {
      if (grid == null || grid.Length == 0)
      {
        return 0;
      }

      return GetSum(grid, 0, 0);
    }

    private int GetSum(int[][] grid, int i, int j)
    {
      if (i >= grid.Length || j >= grid[i].Length)
      {
        return -1;
      }

      var right = GetSum(grid, i, j + 1);
      var down = GetSum(grid, i + 1, j);
      if (right == -1)
      {
        if (down == -1)
          return grid[i][j];
        else
          return grid[i][j] + down;
      }
      else if (down == -1)
      {
        if (right == -1)
          return grid[i][j];
        else
          return grid[i][j] + right;
      }
      else if (right < down)
      {
        return grid[i][j] + right;
      }

      return grid[i][j] + down;
    }
  }
}