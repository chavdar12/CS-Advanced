namespace _001;

internal static class AddVat
{
    private static void Main(string[] args)
    {
        Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList()
            .ForEach(n => Console.WriteLine($"{n * 1.20:f2}"));
    }
}