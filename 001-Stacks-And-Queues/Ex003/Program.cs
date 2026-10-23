namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

        // One full rotation keeps the evens in their original order.
        var count = input.Count;
        for (var i = 0; i < count; i++)
        {
            var number = input.Dequeue();
            if (number % 2 == 0) input.Enqueue(number);
        }

        Console.WriteLine(string.Join(", ", input));
    }
}