namespace _006;

internal static class MaximalSum
{
    private static void Main(string[] args)
    {
        var matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
        var matrix = new int[matrixSizes[0], matrixSizes[1]];
        var matrix3x3 = new int[3, 3];
        var sum = int.MinValue;
        for (var i = 0; i < matrixSizes[0]; i++)
        {
            var row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (var j = 0; j < matrixSizes[1]; j++) matrix[i, j] = row[j];
        }

        for (var i = 0; i < matrixSizes[0] - 2; i++)
        for (var j = 0; j < matrixSizes[1] - 2; j++)
            if (matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] +
                matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2] > sum)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] +
                      matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] +
                      matrix[i + 2, j + 2];
                matrix3x3[0, 0] = matrix[i, j];
                matrix3x3[0, 1] = matrix[i, j + 1];
                matrix3x3[0, 2] = matrix[i, j + 2];
                matrix3x3[1, 0] = matrix[i + 1, j];
                matrix3x3[1, 1] = matrix[i + 1, j + 1];
                matrix3x3[1, 2] = matrix[i + 1, j + 2];
                matrix3x3[2, 0] = matrix[i + 2, j];
                matrix3x3[2, 1] = matrix[i + 2, j + 1];
                matrix3x3[2, 2] = matrix[i + 2, j + 2];
            }

        Console.WriteLine($"Sum = {sum}");
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++) Console.Write(matrix3x3[i, j] + " ");

            Console.WriteLine();
        }
    }
}