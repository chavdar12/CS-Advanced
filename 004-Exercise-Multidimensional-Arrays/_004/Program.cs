namespace _004;

internal static class KnightGame
{
    private static void Main(string[] args)
    {
        var knightPossibleMoves = new Queue<Tuple<int, int>>();
        knightPossibleMoves.Enqueue(new Tuple<int, int>(-1, -2));
        knightPossibleMoves.Enqueue(new Tuple<int, int>(1, -2));
        knightPossibleMoves.Enqueue(new Tuple<int, int>(-2, -1));
        knightPossibleMoves.Enqueue(new Tuple<int, int>(2, -1));
        knightPossibleMoves.Enqueue(new Tuple<int, int>(-2, 1));
        knightPossibleMoves.Enqueue(new Tuple<int, int>(2, 1));
        knightPossibleMoves.Enqueue(new Tuple<int, int>(-1, 2));
        knightPossibleMoves.Enqueue(new Tuple<int, int>(1, 2));
        var chessBoardSize = int.Parse(Console.ReadLine());
        var chessBoard = new char[chessBoardSize, chessBoardSize];
        for (var i = 0; i < chessBoardSize; i++)
        {
            var row = Console.ReadLine().ToCharArray();
            for (var j = 0; j < chessBoardSize; j++) chessBoard[i, j] = row[j];
        }

        var foundMost = true;
        var currentKnightsAround = 0;
        var mostKnightsAround = 0;
        var IdxRowMostKnights = int.MinValue;
        var IdxColMostKnights = int.MinValue;
        var counter = 0;
        while (foundMost)
        {
            for (var i = 0; i < chessBoardSize; i++)
            for (var j = 0; j < chessBoardSize; j++)
            {
                if (chessBoard[i, j] == 'K')
                    for (var k = 1; k <= knightPossibleMoves.Count; k++)
                    {
                        var row = knightPossibleMoves.Peek().Item1;
                        var col = knightPossibleMoves.Peek().Item2;
                        knightPossibleMoves.Enqueue(knightPossibleMoves.Dequeue());
                        try
                        {
                            if (chessBoard[i + row, j + col] == 'K') currentKnightsAround++;
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }

                foundMost = currentKnightsAround > 0;
                if (currentKnightsAround > mostKnightsAround)
                {
                    IdxRowMostKnights = i;
                    IdxColMostKnights = j;
                    mostKnightsAround = currentKnightsAround;
                }

                currentKnightsAround = 0;
            }

            if (foundMost == (IdxRowMostKnights != int.MinValue && IdxColMostKnights != int.MinValue))
            {
                chessBoard[IdxRowMostKnights, IdxColMostKnights] = '0';
                counter++;
            }

            mostKnightsAround = 0;
            IdxRowMostKnights = int.MinValue;
            IdxColMostKnights = int.MinValue;
        }

        Console.WriteLine(counter);
    }
}