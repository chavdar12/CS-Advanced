namespace _003;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var stones = new Lake(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray());

        Console.WriteLine(string.Join(", ", stones));
    }
}