namespace _003;

internal static class CountSameValuesInArray
{
    private static void Main(string[] args)
    {
        var doubles = new Dictionary<double, int>();
        var valuesForDict = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
            .ToArray();
        foreach (var value in valuesForDict)
        {
            if (!doubles.ContainsKey(value)) doubles.Add(value, 0);

            doubles[value]++;
        }

        foreach (var (key, value) in doubles) Console.WriteLine($"{key} - {value} times");
    }
}