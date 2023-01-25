namespace BracketMatchChecker;

public class Program
{
    static void Main(string[] args)
    {
        while (true) {
            Console.WriteLine("Enter string to check whether or not characters in the string have matching brackets '{}'.");
            string input = Console.ReadLine();
            bool isBracketMatched = BracketMatchChecker.Check(input);
            string hasBracketMessage = input.Contains("{") ? "" : " (no brackets in the string will return True)";

            Console.WriteLine(isBracketMatched ? $"Matched {hasBracketMessage}" : "Not Matched");
            Console.ReadLine();
            Console.Clear();
        }
    }


}