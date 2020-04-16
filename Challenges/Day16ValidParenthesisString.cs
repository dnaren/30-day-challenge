
namespace ThirtyDayChallenge.Challenges
{
  public class Day16ValidParenthesisString
  {
    /*
    Given a string containing only three types of characters: '(', ')' and '*', write a function to check whether this string is valid. We define the validity of a string by these rules:

    Any left parenthesis '(' must have a corresponding right parenthesis ')'.
    Any right parenthesis ')' must have a corresponding left parenthesis '('.
    Left parenthesis '(' must go before the corresponding right parenthesis ')'.
    '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string.
    An empty string is also valid.
    Example 1:
    Input: "()"
    Output: True
    Example 2:
    Input: "(*)"
    Output: True
    Example 3:
    Input: "(*))"
    Output: True
    Note:
    The string size will be in the range [1, 100].
    */

    public bool CheckValidString(string s)
    {
      if (s == string.Empty)
        return true;

      if (s[0] == ')')
        return false;

      int lowestPossibility = 0, highestPossibility = 0;
      foreach (var c in s.ToCharArray())
      {
        if (c == '(')
        {
          lowestPossibility++;
          highestPossibility++;
        }
        else if (c == ')')
        {
          if (lowestPossibility > 0)
            lowestPossibility--;
          highestPossibility--;
        }
        else
        {
          if (lowestPossibility > 0)
            lowestPossibility--;
          highestPossibility++;
        }

        if (highestPossibility < 0)
          return false;
      }

      return lowestPossibility == 0;
    }
  }
}