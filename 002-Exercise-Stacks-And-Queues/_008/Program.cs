namespace _008;

internal static class KeyRevolver
{
    private static void Main(string[] args)
    {
        var bulletPrice = int.Parse(Console.ReadLine());
        var barrelSize = int.Parse(Console.ReadLine());
        var bullets = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
        var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        var intelligenceValue = int.Parse(Console.ReadLine());
        var shotsFiredCounter = 0;
        var shotsFiredTotal = 0;
        while (bullets.Count > 0 && locks.Count > 0)
        {
            var isDestroyed = false;
            shotsFiredCounter++;
            shotsFiredTotal++;
            if (bullets.Peek() <= locks.Peek())
            {
                locks.Dequeue();
                isDestroyed = true;
            }

            bullets.Dequeue();
            Console.WriteLine(isDestroyed ? "Bang!" : "Ping!");
            if (shotsFiredCounter != barrelSize || bullets.Count <= 0) continue;
            shotsFiredCounter = 0;
            Console.WriteLine("Reloading!");
        }

        var bulletsCost = shotsFiredTotal * bulletPrice;
        var moneyEarned = intelligenceValue - bulletsCost;
        Console.WriteLine(locks.Count == 0
            ? $"{bullets.Count} bullets left. Earned ${moneyEarned}"
            : $"Couldn't get through. Locks left: {locks.Count}");
    }
}