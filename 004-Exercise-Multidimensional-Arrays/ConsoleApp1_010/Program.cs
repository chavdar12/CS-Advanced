namespace ConsoleApp1_010;

internal static class SquaresInMatrix
{
    private static void Main(string[] args)
    {
        var matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var matrix = new string[matrixSizes[0], matrixSizes[1]];
        var counter = 0;
        for (var i = 0; i < matrixSizes[0]; i++)
        {
            var row = Console.ReadLine().Split();
            for (var j = 0; j < matrixSizes[1]; j++) matrix[i, j] = row[j];
        }

        for (var i = 0; i < matrixSizes[0] - 1; i++)
        for (var j = 0; j < matrixSizes[1] - 1; j++)
            if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] &&
                matrix[i, j] == matrix[i + 1, j + 1])
                counter++;

        Console.WriteLine(counter);
    }
}