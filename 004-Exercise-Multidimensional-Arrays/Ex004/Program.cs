namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var knightPossibleMoves = new (int Row, int Col)[]
        {
            (-1, -2), (1, -2), (-2, -1), (2, -1), (-2, 1), (2, 1), (-1, 2), (1, 2)
        };
        var chessBoardSize = int.Parse(Console.ReadLine());
        var chessBoard = new char[chessBoardSize, chessBoardSize];
        for (var i = 0; i < chessBoardSize; i++)
        {
            var row = Console.ReadLine().ToCharArray();
            for (var j = 0; j < chessBoardSize; j++) chessBoard[i, j] = row[j];
        }

        var counter = 0;
        while (true)
        {
            var mostKnightsAround = 0;
            var idxRowMostKnights = -1;
            var idxColMostKnights = -1;
            for (var i = 0; i < chessBoardSize; i++)
            for (var j = 0; j < chessBoardSize; j++)
            {
                if (chessBoard[i, j] != 'K') continue;

                var currentKnightsAround = knightPossibleMoves.Count(m =>
                    i + m.Row >= 0 && i + m.Row < chessBoardSize &&
                    j + m.Col >= 0 && j + m.Col < chessBoardSize &&
                    chessBoard[i + m.Row, j + m.Col] == 'K');
                if (currentKnightsAround > mostKnightsAround)
                {
                    mostKnightsAround = currentKnightsAround;
                    idxRowMostKnights = i;
                    idxColMostKnights = j;
                }
            }

            if (mostKnightsAround == 0) break;

            chessBoard[idxRowMostKnights, idxColMostKnights] = '0';
            counter++;
        }

        Console.WriteLine(counter);
    }
}
