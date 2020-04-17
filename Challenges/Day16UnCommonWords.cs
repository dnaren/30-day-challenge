namespace ThirtyDayChallenge.Challenges
{
  public class Day16UnCommonWords
  {
    public string[] UncommonFromSentences(string A, string B)
    {
      var aArr = A.Split(' ');
      var bArr = B.Split(' ');
      var length = aArr.Length > bArr.Length ? aArr.Length : bArr.Length;
      var output = new System.Collections.Generic.List<string>();

      for (int i = 0; i < aArr.Length; i++)
      {
        var found = false;
        for (int j = 0; j < bArr.Length; j++)
        {
          if (aArr[i] == bArr[j])
          {
            found = true;
            break;
          }
        }
        if (found)
          continue;

        output.Add(aArr[i]);
      }
      return output.ToArray();
    }
  }
}