namespace _007;

internal static class ListOfPredicates
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var array = new int[n];
        var dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct()
            .ToArray();
        for (var i = 0; i < n; i++) array[i] = i + 1;

        var finalArray = Array.FindAll(array, i =>
        {
            var dividable = false;
            foreach (var div in dividers)
            {
                if (i % div == 0) dividable = true;

                if (!dividable || i % div == 0) continue;
                dividable = false;
                break;
            }

            return dividable;
        });
        Console.WriteLine(string.Join(" ", finalArray));
    }
}