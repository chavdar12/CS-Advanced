namespace _005;

internal static class FindEvenOrOdds
{
    private static void Main(string[] args)
    {
        var boundaries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
        var numbers = new List<int>();
        for (var i = boundaries[0]; i <= boundaries[1]; i++) numbers.Add(i);

        Predicate<int>? predicate = Console.ReadLine() switch
        {
            "even" => i => i % 2 == 0,
            "odd" => i => i % 2 != 0,
            _ => null
        };

        Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));
    }
}