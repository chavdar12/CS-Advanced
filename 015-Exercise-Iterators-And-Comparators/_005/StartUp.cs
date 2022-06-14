namespace _005;

public static class StartUp
{
    private static void Main(string[] args)
    {
        string input;
        var myStack = new CustomStack<string>();
        while ((input = Console.ReadLine()) != "END")
        {
            var commands = input.Split(new[] {" ", ", "}, StringSplitOptions.RemoveEmptyEntries);

            switch (commands[0])
            {
                case "Push":
                    for (var i = 1; i < commands.Length; i++) myStack.Push(commands[i]);

                    break;
                case "Pop":
                    myStack.Pop();
                    break;
            }
        }

        foreach (var item in myStack) Console.WriteLine(item);

        foreach (var item in myStack) Console.WriteLine(item);
    }
}