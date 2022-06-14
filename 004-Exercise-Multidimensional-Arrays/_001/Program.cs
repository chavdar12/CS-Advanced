namespace _001;

internal static class Bombs
{
    private static void Main(string[] args)
    {
        var aoe = new Queue<Tuple<int, int>>();
        aoe.Enqueue(new Tuple<int, int>(-1, -1));
        aoe.Enqueue(new Tuple<int, int>(-1, 0));
        aoe.Enqueue(new Tuple<int, int>(-1, 1));
        aoe.Enqueue(new Tuple<int, int>(0, 1));
        aoe.Enqueue(new Tuple<int, int>(1, 1));
        aoe.Enqueue(new Tuple<int, int>(1, 0));
        aoe.Enqueue(new Tuple<int, int>(1, -1));
        aoe.Enqueue(new Tuple<int, int>(0, -1));

        var matrixSize = int.Parse(Console.ReadLine());
        var matrix = new long[matrixSize, matrixSize];
        for (var i = 0; i < matrixSize; i++)
        {
            var row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (var j = 0; j < matrixSize; j++) matrix[i, j] = row[j];
        }

        var coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach (var coordinate in coordinates)
        {
            var bombIndexes = coordinate.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var idxRow = bombIndexes[0];
            var idxCol = bombIndexes[1];
            if (matrix[idxRow, idxCol] > 0)
            {
                for (var i = 1; i <= aoe.Count; i++)
                {
                    var idxRowAOE = aoe.Peek().Item1;
                    var idxColAOE = aoe.Peek().Item2;
                    aoe.Enqueue(aoe.Dequeue());
                    try
                    {
                        if (matrix[idxRow + idxRowAOE, idxCol + idxColAOE] > 0)
                            matrix[idxRow + idxRowAOE, idxCol + idxColAOE] -= matrix[idxRow, idxCol];
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                matrix[idxRow, idxCol] = 0;
            }
        }

        var query = from long i in matrix
            where i > 0
            select i;
        Console.WriteLine($"Alive cells: {query.Count()}");
        Console.WriteLine($"Sum: {query.Sum()}");
        for (var i = 0; i < matrixSize; i++)
        {
            for (var j = 0; j < matrixSize; j++) Console.Write(matrix[i, j] + " ");

            Console.WriteLine();
        }
    }
}