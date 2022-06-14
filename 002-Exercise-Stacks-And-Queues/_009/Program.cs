namespace _009;

internal static class MaximumAndMinimumElement
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var integers = new Stack<int>();
        for (var i = 0; i < n; i++)
        {
            var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            switch (command[0])
            {
                case "1":
                    integers.Push(int.Parse(command[1]));
                    break;
                case "2":
                    if (integers.Any()) integers.Pop();
                    break;
                case "3":
                    if (integers.Count > 0) Console.WriteLine(integers.Max());
                    break;
                case "4":
                    if (integers.Count > 0) Console.WriteLine(integers.Min());
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", integers));
    }
}