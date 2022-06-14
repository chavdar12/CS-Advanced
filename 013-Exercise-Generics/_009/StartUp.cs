namespace _009;

internal static class StartUp
{
    private static void Main(string[] args)
    {
        var first = Console.ReadLine().Split();
        var name = $"{first[0]} {first[1]}";
        var address = first[2];
        var firstTuple = new Tuple<string, string>(name, address);
        Console.WriteLine(firstTuple);
        var second = Console.ReadLine().Split();
        var secondTuple = new Tuple<string, int>(second[0], int.Parse(second[1]));
        Console.WriteLine(secondTuple);
        var third = Console.ReadLine().Split();
        var numbers = new Tuple<int, double>(int.Parse(third[0]), double.Parse(third[1]));
        Console.WriteLine(numbers);
    }
}