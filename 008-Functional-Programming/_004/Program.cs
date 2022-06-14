namespace _004;

internal static class SortEvenNumbers
{
    private static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ",
            Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .Where(n => n % 2 == 0).OrderBy(n => n).ToArray()));
    }
}