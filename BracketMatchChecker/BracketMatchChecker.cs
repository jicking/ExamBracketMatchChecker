using System.Text.RegularExpressions;

namespace BracketMatchChecker;
public class BracketMatchChecker
{
    public static bool Check(string input)
    {
        const char OPEN_CHAR = '{';
        const char CLOSING_CHAR = '}';

        // sanitize input
        input = Regex.Replace(input, "[^{}]", String.Empty);

        var stack = new Stack<char>();
        foreach (char c in input)
        {
            if (c is OPEN_CHAR)
            {
                stack.Push(c);
            }
            else if (c is CLOSING_CHAR)
            {
                if (stack.Count == 0) return false;
                else stack.Pop();
            }
        }

        return (stack.Count == 0);
    }
}
