namespace _002;

internal static class BasicQueueOperations
{
    private static void Main(string[] args)
    {
        var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        for (var i = 0; i < integers[1]; i++) queue.Dequeue();

        if (queue.Count <= 0)
            Console.WriteLine(0);
        else
            Console.WriteLine(queue.Contains(integers[2]) ? "true" : $"{queue.Min()}");
    }
}