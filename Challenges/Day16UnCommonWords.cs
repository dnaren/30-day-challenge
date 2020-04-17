namespace ThirtyDayChallenge.Challenges
{
  public class Day16UnCommonWords
  {
    public string[] UncommonFromSentences(string A, string B)
    {
      var aArr = A.Split(' ');
      var bArr = B.Split(' ');
      var output = new System.Collections.Generic.List<string>();
      var dictionary = new System.Collections.Generic.Dictionary<string, int>();

      foreach (var word in aArr)
      {
        if (dictionary.ContainsKey(word))
        {
          dictionary[word] = dictionary[word] + 1;
        }
        else
        {
          dictionary.Add(word, 1);
        }
      }

      foreach (var word in bArr)
      {
        if (dictionary.ContainsKey(word))
        {
          dictionary[word] = dictionary[word] + 1;
        }
        else
        {
          dictionary.Add(word, 1);
        }
      }

      foreach (var occurrence in dictionary)
      {
        if (occurrence.Value == 1)
        {
          output.Add(occurrence.Key);
        }
      }

      return output.ToArray();
    }
  }
}