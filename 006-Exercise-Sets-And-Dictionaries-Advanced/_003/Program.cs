namespace _003;

internal static class PeriodicTable
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var table = new SortedSet<string>();
        for (var i = 0; i < n; i++)
        {
            var elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var element in elements) table.Add(element);
        }

        Console.WriteLine(string.Join(" ", table));
    }
}