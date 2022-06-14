namespace _007;

internal static class SymbolInMatrix
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var matrix = new char[n, n];
        for (var i = 0; i < n; i++)
        {
            var row = Console.ReadLine();
            for (var j = 0; j < n; j++) matrix[i, j] = row[j];
        }

        var symbolLookingFor = char.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        for (var j = 0; j < n; j++)
            if (matrix[i, j] == symbolLookingFor)
            {
                Console.WriteLine($"({i}, {j})");
                return;
            }

        Console.WriteLine($"{symbolLookingFor} does not occur in the matrix");
    }
}