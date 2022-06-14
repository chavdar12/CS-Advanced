namespace _006;

internal static class StackSum
{
    private static void Main(string[] args)
    {
        var integers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

        var command = Console.ReadLine().ToLower().Split();
        while (command[0] != "end")
        {
            switch (command[0])
            {
                case "add":
                    integers.Push(int.Parse(command[1]));
                    integers.Push(int.Parse(command[2]));
                    break;
                case "remove":
                    var n = int.Parse(command[1]);
                    if (n <= integers.Count)
                        for (var i = 0; i < n; i++)
                            integers.Pop();

                    break;
            }

            command = Console.ReadLine().ToLower().Split();
        }

        Console.WriteLine($"Sum: {integers.Sum()}");
    }
}