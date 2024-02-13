public class ReverseVowelsApp
{
    static void Main()
    {
        Console.WriteLine(ReverseVowels(" "));
    }

    public static string ReverseVowels(string s)
    {
        List<char> list = new List<char>();
        string aux = "";
        list.Add('a');
        list.Add('e');
        list.Add('i');
        list.Add('o');
        list.Add('u');
        list.Add('A');
        list.Add('E');
        list.Add('I');
        list.Add('O');
        list.Add('U');

        int i = 0;
        int j = s.Length - 1;
        
        if(s.Length == 1)
                return s;
        
        while (i != s.Length)
        {

            if (!list.Contains(s[i]))
            {
                aux += s[i];
                i++;
                continue;
            }
            
            if (!list.Contains(s[j])){
                j--;
                continue;
            }

            aux += s[j];
            i++;
            j--;
        }
        return aux;
    }
}