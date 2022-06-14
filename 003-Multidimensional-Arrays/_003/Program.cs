namespace _003;

internal static class PrimaryDiagonal
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var matrix = new int[n, n];
        var sum = 0;
        for (var i = 0; i < n; i++)
        {
            var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (var j = 0; j < n; j++)
            {
                matrix[i, j] = row[j];
                if (i == j) sum += matrix[i, j];
            }
        }

        Console.WriteLine(sum);
    }
}