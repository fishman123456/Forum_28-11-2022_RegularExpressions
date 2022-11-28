



using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

internal class Program1
{
    private static void Main(string[] args)
    {


        Regex regex = new Regex(@"пок(\w*)");
        string s = "Расскажите про покупки, про какие покупки? Про покупки, про покупки, Про покупочки мои...";
        MatchCollection matches = regex.Matches(s);
        if (matches.Count > 0)
        {
            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }
        else
        {
            Console.WriteLine("Совпадений не найдено");
        }
        Console.WriteLine(s);
        Console.WriteLine(matches.Count+" замен с содержанием пок");
        string target = "Ю";
        Regex regex1 = new Regex(s);
        string result = regex.Replace(s, target);
        Console.WriteLine(result);

    }
}