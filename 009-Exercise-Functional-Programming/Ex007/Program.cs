namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var array = new int[n];
        var dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct()
            .ToArray();
        for (var i = 0; i < n; i++) array[i] = i + 1;

        var finalArray = Array.FindAll(array, i => dividers.All(div => i % div == 0));
        Console.WriteLine(string.Join(" ", finalArray));
    }
}