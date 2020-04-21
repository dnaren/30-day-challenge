namespace ThirtyDayChallenge.Challenges
{
  public class Day17NumberOfIslands
  {
    /*
    Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

    Example 1:

    Input:
    11110
    11010
    11000
    00000

    Output: 1
    Example 2:

    Input:
    11000
    11000
    00100
    00011

    Output: 3
    */

    public int NumIslands(char[][] grid)
    {
      if (grid == null || grid.Length == 0)
        return 0;

      var noOfIslands = 0;

      for (int i = 0; i < grid.Length; i++)
      {
        for (int j = 0; j < grid[i].Length; j++)
        {
          if (grid[i][j] == '1')
          {
            noOfIslands += FindIslands(grid, i, j);
          }
        }
      }

      return noOfIslands;
    }

    private int FindIslands(char[][] grid, int i, int j)
    {
      //Note - we are quiting this recursive call the moment we encounter a 0
      if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
      {
        return 0;
      }

      //we are setting the 1 to 0 - so mark it has been visited
      grid[i][j] = '0';

      //we are also visiting every other 1s that are continuous to the initial 1 
      //and are setting them to 0s (i.e. continuous & visited)
      //making it 1 island
      FindIslands(grid, i - 1, j);
      FindIslands(grid, i + 1, j);
      FindIslands(grid, i, j - 1);
      FindIslands(grid, i, j + 1);

      return 1;
    }

    // private void Print(char[] row)
    // {
    //   foreach (var c in row)
    //   {
    //     Console.Write(c);
    //   }
    //   Console.WriteLine();
    // }
  }
}