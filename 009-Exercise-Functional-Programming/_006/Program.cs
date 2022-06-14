namespace _006;

internal static class KnightsOfHonor
{
    private static void Main(string[] args)
    {
        string AddPrefix(string str)
        {
            return str.Insert(0, "Sir ");
        }

        Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select((Func<string, string>) AddPrefix)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}