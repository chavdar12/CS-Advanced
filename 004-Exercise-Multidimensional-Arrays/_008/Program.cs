namespace _008;

internal static class RadioactiveMutantVampireBunnies
{
    private static void Main(string[] args)
    {
        var bunnyMultiply = new Queue<Tuple<int, int>>();
        bunnyMultiply.Enqueue(new Tuple<int, int>(-1, 0));
        bunnyMultiply.Enqueue(new Tuple<int, int>(0, 1));
        bunnyMultiply.Enqueue(new Tuple<int, int>(1, 0));
        bunnyMultiply.Enqueue(new Tuple<int, int>(0, -1));
        var lairSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
        var lair = new char[lairSizes[0], lairSizes[1]];
        for (var i = 0; i < lairSizes[0]; i++)
        {
            var row = Console.ReadLine();
            for (var j = 0; j < lairSizes[1]; j++) lair[i, j] = row[j];
        }

        var commands = Console.ReadLine();
        var playerIndexes = new int[2];
        for (var i = 0; i < lair.GetLength(0); i++)
        for (var j = 0; j < lair.GetLength(1); j++)
            if (lair[i, j] == 'P')
            {
                playerIndexes[0] = i;
                playerIndexes[1] = j;
            }

        var isDead = false;
        var isWon = false;
        foreach (var command in commands)
        {
            lair[playerIndexes[0], playerIndexes[1]] = '.';
            switch (command)
            {
                case 'U':
                    playerIndexes[0]--;
                    if (playerIndexes[0] < 0)
                    {
                        playerIndexes[0]++;
                        isWon = true;
                    }

                    break;
                case 'D':
                    playerIndexes[0]++;
                    if (playerIndexes[0] >= lair.GetLength(0))
                    {
                        playerIndexes[0]--;
                        isWon = true;
                    }

                    break;
                case 'L':
                    playerIndexes[1]--;
                    if (playerIndexes[1] < 0)
                    {
                        playerIndexes[1]++;
                        isWon = true;
                    }

                    break;
                case 'R':
                    playerIndexes[1]++;
                    if (playerIndexes[1] >= lair.GetLength(1))
                    {
                        playerIndexes[1]--;
                        isWon = true;
                    }

                    break;
            }

            if (lair[playerIndexes[0], playerIndexes[1]] == 'B')
                isDead = true;
            else if (lair[playerIndexes[0], playerIndexes[1]] != 'B' && !isWon)
                lair[playerIndexes[0], playerIndexes[1]] = 'P';

            var bunniesIndexes = new Queue<int[]>();
            for (var i = 0; i < lair.GetLength(0); i++)
            for (var j = 0; j < lair.GetLength(1); j++)
                if (lair[i, j] == 'B')
                    bunniesIndexes.Enqueue(new[] {i, j});

            var bunnyCount = bunniesIndexes.Count;
            for (var i = 0; i < bunnyCount; i++)
            {
                var bunnyIdxRow = bunniesIndexes.Peek()[0];
                var bunnyIdxCol = bunniesIndexes.Peek()[1];
                bunniesIndexes.Dequeue();
                for (var k = 0; k < bunnyMultiply.Count; k++)
                {
                    var mplyIdxRow = bunnyMultiply.Peek().Item1;
                    var mplyIdxCol = bunnyMultiply.Peek().Item2;
                    bunnyMultiply.Enqueue(bunnyMultiply.Dequeue());
                    try
                    {
                        if (lair[bunnyIdxRow + mplyIdxRow, bunnyIdxCol + mplyIdxCol] == 'P')
                        {
                            isDead = true;
                            lair[playerIndexes[0], playerIndexes[1]] = '.';
                        }

                        lair[bunnyIdxRow + mplyIdxRow, bunnyIdxCol + mplyIdxCol] = 'B';
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }

            if (isWon || isDead) break;
        }

        for (var i = 0; i < lair.GetLength(0); i++)
        {
            for (var j = 0; j < lair.GetLength(1); j++) Console.Write(lair[i, j]);

            Console.WriteLine();
        }

        Console.WriteLine(isWon
            ? $"won: {playerIndexes[0]} {playerIndexes[1]}"
            : $"dead: {playerIndexes[0]} {playerIndexes[1]}");
    }
}