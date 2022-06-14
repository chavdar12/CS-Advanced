namespace _004;

internal static class CustomMinFunction
{
    private static void Main(string[] args)
    {
        int Min(IEnumerable<int> i)
        {
            return i.Prepend(int.MaxValue).Min();
        }

        Console.WriteLine(Min(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray()));
    }
}