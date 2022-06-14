namespace _002;

internal static class CountUppercaseWords
{
    private static void Main(string[] args)
    {
        Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(c => char.IsUpper(c[0])).ToList()
            .ForEach(Console.WriteLine);
    }
}