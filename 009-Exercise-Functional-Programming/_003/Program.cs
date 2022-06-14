namespace _003;

internal static class CustomComparator
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var compare = Comparer<int>.Create((i, j) =>
        {
            if (i == j)
                return 0;
            if (i % 2 == 0 && j % 2 != 0)
                return -1;
            if (i % 2 == 0 && j % 2 == 0)
                return i < j ? -1 : 1;
            if (i % 2 != 0 && j % 2 != 0)
                return i < j ? -1 : 1;

            return 1;
        });
        Array.Sort(numbers, compare);
        Console.WriteLine(string.Join(" ", numbers));
    }
}