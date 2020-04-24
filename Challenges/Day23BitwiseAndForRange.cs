namespace ThirtyDayChallenge.Challenges
{
  public class Day23BitwiseAndForRange
  {

    /*
    Given a range [m, n] where 0 <= m <= n <= 2147483647, return the bitwise AND of all numbers in this range, inclusive.

    Example 1:

    Input: [5,7]
    Output: 4
    Example 2:

    Input: [0,1]
    Output: 0
    */
    public int RangeBitwiseAnd(int m, int n)
    {
      if (m < 0 || n < 0)
        return 0;

      return DoBitwiseAnd(m, n);
    }

    private static int GetMostSignificantBitLocation(int n)
    {
      var msb = -1;
      while (n > 0)
      {
        n = n >> 1;
        msb++;
      }
      return msb;
    }

    private static int DoBitwiseAnd(int m, int n)
    {
      var output = 0;

      while (m > 0 && n > 0)
      {
        var mMsb = GetMostSignificantBitLocation(m);
        var nMsb = GetMostSignificantBitLocation(n);

        if (mMsb != nMsb)
          break;

        var msbValue = 1 << mMsb;
        output += msbValue;

        m = m - msbValue;
        n = n - msbValue;
      }

      return output;
    }
  }
}