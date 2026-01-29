namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var kids = new Queue<string>(Console.ReadLine().Split());
        var tosses = int.Parse(Console.ReadLine());
        while (kids.Count > 1)
        {
            for (var i = 1; i < tosses; i++) kids.Enqueue(kids.Dequeue());

            Console.WriteLine($"Removed {kids.Dequeue()}");
        }

        Console.WriteLine($"Last is {kids.Peek()}");
    }
}