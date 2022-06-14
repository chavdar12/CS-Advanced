namespace _005;

internal static class SimpleCalculator
{
    private static void Main(string[] args)
    {
        var elements = new Stack<string>(Console.ReadLine().Split().Reverse());
        while (elements.Count > 1)
        {
            var a = int.Parse(elements.Pop());
            var @operator = elements.Pop();
            var b = int.Parse(elements.Pop());
            elements.Push(@operator == "+" ? (a + b).ToString() : (a - b).ToString());
        }

        Console.WriteLine(elements.Pop());
    }
}