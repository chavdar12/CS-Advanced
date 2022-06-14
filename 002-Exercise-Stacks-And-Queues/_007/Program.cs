namespace _007;

internal static class FastFood
{
    private static void Main(string[] args)
    {
        var qtyFood = int.Parse(Console.ReadLine());
        var orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        var biggestOrder = orders.Max();
        var count = orders.Count;
        for (var i = 0; i < count; i++)
            if (qtyFood >= orders.Peek())
                qtyFood -= orders.Dequeue();
        Console.WriteLine(biggestOrder);

        Console.WriteLine(orders.Count <= 0 ? "Orders complete" : $"Orders left: {string.Join(" ", orders)}");
    }
}