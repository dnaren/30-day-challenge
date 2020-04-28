using System;
namespace ThirtyDayChallenge.Challenges
{
  public class Day26MaximalSquare
  {
    /*
    Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

    Example:

    Input: 

    1 0 1 0 0
    1 0 1 1 1
    1 1 1 1 1
    1 0 0 1 0

    Output: 4
    */

    public int MaximalSquare(char[][] matrix)
    {
      if (matrix == null || matrix.Length == 0)
        return 0;

      return GetMaxSquare(matrix);
    }

    private int GetMaxSquare(char[][] matrix)
    {
      int rows = matrix.Length;
      int cols = matrix[0].Length;

      int[][] dp = new int[rows + 1][];
      int max = 0;
      for (int i = 0; i <= rows; i++)
      {
        dp[i] = new int[cols + 1];
        for (int j = 0; j <= cols; j++)
        {
          dp[i][j] = 0;
        }
      }

      for (int i = 1; i <= rows; i++)
      {
        for (int j = 1; j <= cols; j++)
        {
          if (matrix[i - 1][j - 1] == '1')
          {
            dp[i][j] = Math.Min(dp[i - 1][j - 1], Math.Min(dp[i - 1][j], dp[i][j - 1])) + 1;
            max = Math.Max(max, dp[i][j]);
          }
        }
      }

      return max * max;
    }
  }
}