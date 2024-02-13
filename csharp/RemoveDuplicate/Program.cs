namespace RemoveDuplicate
{
  public class RemoveDuplicate
  {
    static void Main()
    {
      Console.WriteLine(RemoveDuplicates("abbaca"));
    }

    public static string RemoveDuplicates(string s)
    {
      string text = "";
      for (int i = 0; i < s.Length- 1; i++)
      {
        if (i == 0)
          text += s[i];
        else
        {
          if (s[i] != text[i-1])
            text += s[i];
        }
      }

      return text;
    }
  }
}