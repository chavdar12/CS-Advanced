namespace Ex001;

internal class Program
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
            if (pairs.ContainsKey(parenthesis))
            {
                parenthesesStack.Push(parenthesis);
            }
            else if (parenthesesStack.Count == 0 || pairs[parenthesesStack.Pop()] != parenthesis)
            {
                isBalanced = false;
                break;
            }
        }

        Console.WriteLine(isBalanced && parenthesesStack.Count == 0 ? "YES" : "NO");
    }
}