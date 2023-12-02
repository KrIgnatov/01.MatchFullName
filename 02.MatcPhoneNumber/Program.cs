    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\+359( |-)2\1\d{3}( |-)\d{4}\b";
            Regex regex = new Regex(pattern);


            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
