namespace _005;

internal static class CupsAndBottles
{
    private static void Main(string[] args)
    {
        var cups = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
        var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        var wastedWater = 0;

        while (cups.Count > 0 && bottles.Count > 0)
        {
            if (cups.Peek() - bottles.Peek() <= 0)
            {
                wastedWater += Math.Abs(cups.Peek() - bottles.Peek());
                cups.Pop();
            }
            else
            {
                cups.Push(cups.Pop() - bottles.Peek());
            }

            bottles.Pop();
        }

        Console.WriteLine(cups.Count == 0
            ? $"Bottles: {string.Join(" ", bottles)}"
            : $"Cups: {string.Join(" ", cups)}");
        Console.WriteLine($"Wasted litters of water: {wastedWater}");
    }
}