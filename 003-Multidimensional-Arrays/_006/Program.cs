namespace _006;

internal static class SumMatrixElements
{
    private static void Main(string[] args)
    {
        var matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        var matrix = new int[matrixSize[0], matrixSize[1]];
        var sum = 0;
        for (var i = 0; i < matrixSize[0]; i++)
        {
            var row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (var j = 0; j < matrixSize[1]; j++)
            {
                matrix[i, j] = row[j];
                sum += row[j];
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, matrixSize));
        Console.WriteLine(sum);
    }
}