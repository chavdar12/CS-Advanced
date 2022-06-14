namespace _003;

internal static class BasicStackOperations
{
    private static void Main(string[] args)
    {
        //integers[0] - how many pushes, integers[1] - how many pops, integers[2] - which number to look for if the stack contains it.
        var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        for (var i = 0; i < integers[1]; i++) stack.Pop();

        if (stack.Count <= 0)
            Console.WriteLine(0);
        else
            Console.WriteLine(stack.Contains(integers[2]) ? "true" : $"{stack.Min()}");
    }
}