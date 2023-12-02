using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        MatchCollection matches = Regex.Matches(inputText, pattern);

        foreach (Match match in matches)
        {
            Console.Write($"{match.Value} ");
        }
    }
}
