namespace _012;

internal static class TriFunction
{
    private static void Main(string[] args)
    {
        var threshold = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(names.First(n => n.Select(c => (int) c).Sum() >= threshold));
    }
}