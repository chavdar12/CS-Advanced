namespace _005;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var strings = new List<Box<string>>();
        for (var i = 0; i < n; i++)
        {
            var currentBox = new Box<string>(Console.ReadLine());
            strings.Add(currentBox);
        }

        Console.WriteLine(FilterCount(strings, Console.ReadLine()));
    }

    private static int FilterCount<T>(List<Box<T>> list, T item) where T : IComparable
    {
        return list.Count(b => b.Value.CompareTo(item) > 0);
    }
}