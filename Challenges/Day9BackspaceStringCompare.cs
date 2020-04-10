using System.Text;
namespace ThirtyDayChallenge.Challenges
{
  public class Day9BackspaceStringCompare
  {
    /*
    Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.

    Example 1:

    Input: S = "ab#c", T = "ad#c"
    Output: true
    Explanation: Both S and T become "ac".
    Example 2:

    Input: S = "ab##", T = "c#d#"
    Output: true
    Explanation: Both S and T become "".
    Example 3:

    Input: S = "a##c", T = "#a#c"
    Output: true
    Explanation: Both S and T become "c".
    Example 4:

    Input: S = "a#c", T = "b"
    Output: false
    Explanation: S becomes "c" while T becomes "b".
    Note:

    1 <= S.length <= 200
    1 <= T.length <= 200
    S and T only contain lowercase letters and '#' characters.
    Follow up:

    Can you solve it in O(N) time and O(1) space?
    
    */
    public bool BackspaceCompare(string S, string T)
    {
      if (Reduce(S).Equals(Reduce(T)))
        return true;

      return false;
    }

    private string Reduce(string input)
    {
      var output = new StringBuilder(input.Length);
      foreach (var c in input.ToCharArray())
      {
        if (c != '#')
        {
          output.Append(c);
        }
        else if (output.Length > 0)
        {
          output.Remove(output.Length - 1, 1);
        }
      }

      return output.ToString();
    }

  }
}