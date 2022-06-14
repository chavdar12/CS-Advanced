namespace _002;

internal static class DiagonalDifference
{
    private static void Main(string[] args)
    {
        var matrixSize = int.Parse(Console.ReadLine());
        var matrix = new int[matrixSize, matrixSize];
        var sum1 = 0;
        var sum2 = 0;
        for (var i = 0; i < matrixSize; i++)
        {
            var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (var j = 0; j < row.Length; j++) matrix[i, j] = row[j];
        }

        for (var i = 0; i < matrixSize; i++)
        for (var j = 0; j < matrixSize; j++)
            if (i == j)
                sum1 += matrix[i, j];

        var reverseCounter = matrixSize - 1;
        for (var i = 0; i < matrixSize; i++)
        for (var j = 0; j < matrixSize; j++)
            if (j == reverseCounter)
            {
                sum2 += matrix[i, j];
                reverseCounter--;
                break;
            }

        Console.WriteLine(Math.Abs(sum1 - sum2));
    }
}