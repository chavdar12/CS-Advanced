namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());

        while (input.Any(i => i % 2 != 0))
            if (input.Peek() % 2 == 0)
                input.Enqueue(input.Dequeue());
            else
                input.Dequeue();

        Console.WriteLine(string.Join(", ", input.Reverse()));
    }
}