namespace _007;

internal static class Miner
{
    private static void Main(string[] args)
    {
        long fieldSize = int.Parse(Console.ReadLine());
        var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var field = new char[fieldSize, fieldSize];
        var minerIndexes = new int[2];
        var coalCounter = 0;
        for (var i = 0; i < fieldSize; i++)
        {
            var row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (var j = 0; j < fieldSize; j++) field[i, j] = char.Parse(row[j]);
        }


        for (var i = 0; i < fieldSize; i++)
        for (var j = 0; j < fieldSize; j++)
            if (field[i, j] == 's')
            {
                minerIndexes[0] = i;
                minerIndexes[1] = j;
            }

        foreach (var c in command)
        {
            switch (c)
            {
                case "up":
                    minerIndexes[0] -= 1;
                    if (minerIndexes[0] < 0) minerIndexes[0] += 1;
                    break;
                case "down":
                    minerIndexes[0] += 1;
                    if (minerIndexes[0] >= field.GetLength(0)) minerIndexes[0] -= 1;
                    break;
                case "left":
                    minerIndexes[1] -= 1;
                    if (minerIndexes[1] < 0) minerIndexes[1] += 1;
                    break;
                case "right":
                    minerIndexes[1] += 1;
                    if (minerIndexes[1] >= field.GetLength(1)) minerIndexes[1] -= 1;
                    break;
            }

            if (field[minerIndexes[0], minerIndexes[1]] == 'c')
            {
                coalCounter++;
                field[minerIndexes[0], minerIndexes[1]] = '*';
                var query = from char element in field where element == 'c' select element;
                if (!query.Any())
                {
                    Console.WriteLine($"You collected all coals! ({minerIndexes[0]}, {minerIndexes[1]})");
                    return;
                }
            }
            else if (field[minerIndexes[0], minerIndexes[1]] == 'e')
            {
                Console.WriteLine($"Game over! ({minerIndexes[0]}, {minerIndexes[1]})");
                return;
            }
        }

        var coals = from char element in field where element == 'c' select element;
        Console.WriteLine($"{coals.Count()} coals left. ({minerIndexes[0]}, {minerIndexes[1]})");
    }
}