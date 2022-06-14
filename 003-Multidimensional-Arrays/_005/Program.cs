namespace _005;

internal static class SumMatrixColumns
{
    private static void Main(string[] args)
    {
        var matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        var matrix = new int[matrixSizes[0], matrixSizes[1]];
        for (var i = 0; i < matrixSizes[0]; i++)
        {
            var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (var j = 0; j < matrixSizes[1]; j++) matrix[i, j] = row[j];
        }

        for (var i = 0; i < matrixSizes[1]; i++)
        {
            var columnSum = 0;
            for (var j = 0; j < matrixSizes[0]; j++) columnSum += matrix[j, i];

            Console.WriteLine(columnSum);
        }
    }
}