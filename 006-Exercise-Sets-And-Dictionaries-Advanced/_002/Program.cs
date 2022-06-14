namespace _002;

internal static class EvenTimes
{
    private static void Main(string[] args)
    {
        var occurrences = new Dictionary<string, int>();
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var value = Console.ReadLine();
            if (!occurrences.ContainsKey(value)) occurrences.Add(value, 0);

            occurrences[value]++;
        }

        Console.WriteLine(occurrences.First(o => o.Value % 2 == 0).Key);
    }
}