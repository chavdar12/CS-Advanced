namespace _002;

internal static class AppliedArithmetics
{
    private static void Main(string[] args)
    {
        void Add(IList<int> i)
        {
            for (var j = 0; j < i.Count; j++) i[j]++;
        }

        void Multiply(IList<int> i)
        {
            for (var j = 0; j < i.Count; j++) i[j] *= 2;
        }

        void Subtract(IList<int> i)
        {
            for (var j = 0; j < i.Count; j++) i[j]--;
        }

        void Print(IEnumerable<int> i)
        {
            Console.WriteLine(string.Join(" ", i));
        }

        var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        string input;
        while ((input = Console.ReadLine()) != "end")
            switch (input)
            {
                case "add":
                    Add(numbers);
                    break;
                case "subtract":
                    Subtract(numbers);
                    break;
                case "multiply":
                    Multiply(numbers);
                    break;
                case "print":
                    Print(numbers);
                    break;
            }
    }
}