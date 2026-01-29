namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var strToReverse = new Stack<char>(Console.ReadLine().ToCharArray());
        while (strToReverse.Count > 0) Console.Write(strToReverse.Pop());
    }
}