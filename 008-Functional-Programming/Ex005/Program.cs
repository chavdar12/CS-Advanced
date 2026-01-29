namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Console.WriteLine(input.Length);
        Console.WriteLine(input.Sum());
    }
}