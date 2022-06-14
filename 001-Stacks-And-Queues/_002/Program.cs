namespace _002;

internal static class MatchingBrackets
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var indexes = new Stack<int>();
        for (var i = 0; i < input.Length; i++)
            switch (input[i])
            {
                case '(':
                    indexes.Push(i);
                    break;
                case ')':
                    var index = indexes.Pop();
                    Console.WriteLine(input.Substring(index, i - index + 1));
                    break;
            }
    }
}