namespace _005;

internal static class SetsOfElements
{
    private static void Main(string[] args)
    {
        var first = new HashSet<string>();
        var second = new HashSet<string>();
        var iterations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
        for (var i = 0; i < iterations[0]; i++) first.Add(Console.ReadLine());

        for (var i = 0; i < iterations[1]; i++) second.Add(Console.ReadLine());

        first.IntersectWith(second);
        Console.WriteLine(string.Join(" ", first));
    }
}