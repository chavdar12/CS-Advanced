namespace _004;

internal static class StartUp
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var doubles = new List<Box<double>>();
        for (var i = 0; i < n; i++)
        {
            var currentBox = new Box<double>(double.Parse(Console.ReadLine()));
            doubles.Add(currentBox);
        }

        Console.WriteLine(FilterCount(doubles, double.Parse(Console.ReadLine())));
    }

    private static int FilterCount<T>(List<Box<T>> list, T item) where T : IComparable
    {
        return list.Count(b => b.Value.CompareTo(item) > 0);
    }
}