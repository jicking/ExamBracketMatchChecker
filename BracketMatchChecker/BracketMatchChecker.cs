using System.Text.RegularExpressions;

namespace BracketMatchChecker;
public class BracketMatchChecker
{
    public static bool Check(string input)
    {
        const char OPEN_CHAR = '{';

        // sanitize input, only keeps brackets
        input = Regex.Replace(input, "[^{}]", String.Empty);

        var stack = new Stack<char>();
        foreach (char c in input)
        {
            if (c is OPEN_CHAR)
            {
                stack.Push(c);
                continue;
            }

            // now assumes current c is closing char
            if (stack.Count == 0) return false;

            stack.Pop();
        }

        return (stack.Count == 0);
    }
}
