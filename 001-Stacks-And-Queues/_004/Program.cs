namespace _004;

internal static class ReverseStrings
{
    private static void Main(string[] args)
    {
        var strToReverse = new Stack<char>(Console.ReadLine().ToCharArray());
        while (strToReverse.Count > 0) Console.Write(strToReverse.Pop());
    }
}