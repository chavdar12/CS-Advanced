using System.Text;

namespace _009;

internal static class SnakeMoves
{
    private static void Main(string[] args)
    {
        var matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
        var snake = new StringBuilder(Console.ReadLine());
        var snakeTemp = snake.ToString();
        var snakePath = new char[matrixSizes[0], matrixSizes[1]];
        for (var i = 0; i < matrixSizes[0]; i++)
            if (i % 2 == 0)
                for (var j = 0; j < matrixSizes[1]; j++)
                {
                    if (snake.Length == 0) snake.Append(snakeTemp);
                    snakePath[i, j] = snake[0];
                    snake.Remove(0, 1);
                }
            else
                for (var j = matrixSizes[1] - 1; j >= 0; j--)
                {
                    if (snake.Length == 0) snake.Append(snakeTemp);
                    snakePath[i, j] = snake[0];
                    snake.Remove(0, 1);
                }

        for (var i = 0; i < matrixSizes[0]; i++)
        {
            for (var j = 0; j < matrixSizes[1]; j++) Console.Write(snakePath[i, j]);

            Console.WriteLine();
        }
    }
}