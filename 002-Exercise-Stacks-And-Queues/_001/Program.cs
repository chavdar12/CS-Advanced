namespace _001;

internal static class BalancedParentheses
{
    private static void Main(string[] args)
    {
        var parentheses = Console.ReadLine();

        var parenthesesStack = new Stack<char>();
        var isBalanced = true;
        var pairs = new Dictionary<char, char>();
        pairs.Add('(', ')');
        pairs.Add('[', ']');
        pairs.Add('{', '}');

        foreach (var parenthesis in parentheses)
        {
            if (parentheses.Length % 2 != 0 || parentheses.Length == 0)
            {
                isBalanced = false;
                break;
            }

            if (pairs.ContainsKey(parenthesis))
            {
                parenthesesStack.Push(parenthesis);
            }
            else
            {
                var openParenthesis = parenthesesStack.Pop();
                if (pairs[openParenthesis] != parenthesis) isBalanced = false;
            }
        }

        Console.WriteLine(isBalanced ? "YES" : "NO");
    }
}