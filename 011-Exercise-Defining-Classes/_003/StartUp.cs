using System;

namespace _003;

internal static class StartUp
{
    private static void Main(string[] args)
    {
        var date1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var firstDate = new DateTime(int.Parse(date1[0]), int.Parse(date1[1].TrimStart('0')),
            int.Parse(date1[2].TrimStart('0')));
        var date2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var secondDate = new DateTime(int.Parse(date2[0]), int.Parse(date2[1].TrimStart('0')),
            int.Parse(date2[2].TrimStart('0')));
        Console.WriteLine(DateModifier.GetDifferenceOfDates(firstDate, secondDate));
    }
}