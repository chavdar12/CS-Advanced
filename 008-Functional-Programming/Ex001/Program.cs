namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList()
            .ForEach(n => Console.WriteLine($"{n * 1.20:f2}"));
    }
}