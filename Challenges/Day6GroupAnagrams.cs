using System;
using System.Linq;
using System.Collections.Generic;

namespace ThirtyDayChallenge.Challenges
{
  public class Day6GroupAnagrams
  {
    /*
    Given an array of strings, group anagrams together.

    Example:

    Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
    Output:
    [
      ["ate","eat","tea"],
      ["nat","tan"],
      ["bat"]
    ]
    Note:

    All inputs will be in lowercase.
    The order of your output does not matter.
    */
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
      IList<IList<string>> output = new List<IList<string>>();
      IList<IList<string>> actualOutput = new List<IList<string>>();

      var copy = new List<string>();
      foreach (var s in strs)
      {
        var item = string.Concat(s.OrderBy(c => c));
        Console.WriteLine(item);
        copy.Add(item);
      }
      for (int i = 0; i < copy.Count; i++)
      {
        var added = false;
        if (output.Any())
        {
          for (int i1 = 0; i1 < output.Count; i1++)
          {
            IList<string> o = output[i1];
            IList<string> ao = actualOutput[i1];

            if (o.Contains(copy[i]))
            {
              o.Add(copy[i]);
              ao.Add(strs[i]);
              added = true;
              break;
            }
          }
        }
        if (!added)
        {
          actualOutput.Add(new List<string> { strs[i] });
          output.Add(new List<string> { copy[i] });
        }
      }

      return actualOutput;
    }

    public IList<IList<string>> GroupAnagrams2(string[] strs)
    {
      var map = new Dictionary<string, List<string>>();

      foreach (var w in strs)
      {
        char[] c = w.ToCharArray();
        Array.Sort(c);
        var sorted = new String(c);

        if (map.ContainsKey(sorted))
        {
          map[sorted].Add(w);
        }
        else
        {
          map.Add(sorted, new List<string> { w });
        }
      }

      IList<IList<string>> output = new List<IList<string>>();
      foreach (var s in map)
      {
        output.Add(s.Value);
      }

      return output;
    }
  }
}